using Project_IPET.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_IPET
{
    public partial class FrmCommentManagement : Form
    {
        public FrmCommentManagement()
        {
            InitializeComponent();
            ShowCbx();
            ShowComment();
            this.cbxReply.DataSource = this.dbContext.CommentReplies.AsEnumerable().Select(c => $"{c.ReplyContent}").ToList();
        }

        private void ShowCbx()
        {
            this.cbxRating.DataSource = (from q in this.dbContext.Comments.AsEnumerable()
                                         orderby q.Rating
                                         select $"{q.Rating}星評價").Distinct().ToList();


            this.cbxMemberName.DataSource = (from c in this.dbContext.Comments.AsEnumerable()
                                             where c.OrderDetail.Order.Member.Name != "Admin"
                                             orderby c.OrderDetail.Order.Member.Name
                                             select c.OrderDetail.Order.Member.Name).Distinct().ToList();

            
        }

        MyProjectEntities dbContext = new MyProjectEntities();




        private void ShowComment()
        {

            var q = from c in this.dbContext.Comments.AsEnumerable()

                    select new
                    {
                        序號 = c.CommentID,
                        產品名稱 = c.OrderDetail.Product.ProductName,
                        訂單編號 = c.OrderDetail.OrderID,
                        評價會員 = c.OrderDetail.Order.Member.Name,
                        評價日期 = c.CommentDate,
                        評價內容 = c.CommentContent,
                        評價回覆 = c.ReplyContent,
                        回覆狀態 = c.Reply,
                        評價星級 = $"{c.Rating}星評價",
                        屏蔽狀態 = c.Banned

                    };

            this.dgvComment.DataSource = q.ToList();

        }

        private IEnumerable<Comment> createfilter()
        {
            bool Ratingfilter = ckxFilterRating.Checked;
            bool CommentDatefilter = ckxFilterCommentDate.Checked;
            bool Memberfilter = ckxFilterMemberName.Checked;
            bool Replyfilter = ckxFilterReply.Checked;
            IEnumerable<Comment> filterresult = null;

                filterresult = from c in this.dbContext.Comments.AsEnumerable()
                               select c;

            if (Ratingfilter == true)
            {
                filterresult = from c in filterresult.AsEnumerable()
                               where $"{c.Rating}星評價" == this.cbxRating.Text
                               select c;
            }
            if (CommentDatefilter == true)
            {
                filterresult = from c in filterresult.AsEnumerable()
                               where c.CommentDate >= dtpCommentDateFirst.Value.Date && c.CommentDate <= dtpCommentDateLast.Value.Date
                               select c;
            }
            if (Memberfilter == true)
            {
                filterresult = from c in filterresult.AsEnumerable()
                               where c.OrderDetail.Order.Member.Name == cbxMemberName.Text
                               select c;

            }
            if (Replyfilter  == true)
            {
                filterresult = from c in filterresult.AsEnumerable()
                               where !c.Reply
                               select c;

            }

            return filterresult;

        }

        private void createview(IEnumerable<Comment> filterresult)
        {
            var viewresult = from c in filterresult.AsEnumerable()
                    select new
                    {
                        序號 = c.CommentID,
                        產品名稱 = c.OrderDetail.Product.ProductName,
                        訂單編號 = c.OrderDetail.OrderID,
                        評價會員 = c.OrderDetail.Order.Member.Name,
                        評價日期 = c.CommentDate,
                        評價內容 = c.CommentContent,
                        評價回覆 = c.ReplyContent,
                        回覆狀態 = c.Reply,
                        評價星級 = $"{c.Rating}星評價",
                        屏蔽狀態 = c.Banned


                    };

            this.dgvComment.DataSource = viewresult.ToList();
        }


        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowComment();
        }

       
        private void btnShieldComment_Click(object sender, EventArgs e)
        {

            var result = createfilter();
            
            string temp = "";

            int CellID = (int)this.dgvComment.CurrentRow.Cells[0].Value;

            var q = from p in result
                     where p.CommentID == CellID
                     select p;

            foreach (var Banned in q)
            {
                temp = Banned.CommentContent;
                Banned.CommentContent = Banned.BannedContent;
                Banned.BannedContent = temp;
                Banned.Banned = !Banned.Banned;
                if (Banned.Banned == false)
                {
                    MessageBox.Show($"{CellID}號留言解除屏蔽");
                }
                else
                {
                    MessageBox.Show($"屏蔽{CellID}號留言");
                }
            }
            this.dbContext.SaveChanges();

          
            createview(result);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var result = createfilter();
            createview(result);
        }


        bool sort = false;
        private void btnCommentSort_Click(object sender, EventArgs e)
        {
            var result = createfilter();
            bool RatingSort = ckxSortRating.Checked;
            bool CommentDateSort = ckxSortCommentDate.Checked;
            bool BannedSort = ckxSortBanned.Checked;
            if (sort)
            {
                if (RatingSort)
                {
                    result = from c in result.AsEnumerable()
                             orderby c.Rating
                             select c;

                }
                if (BannedSort)
                {
                    result = from c in result.AsEnumerable()
                             orderby c.Banned
                             select c;
                }
       
               
                if (CommentDateSort)
                {
                    result = from c in result.AsEnumerable()
                             orderby c.CommentDate
                             select c;
                }

         
            }
            else
            {
                if (RatingSort)
                {
                    result = from c in result.AsEnumerable()
                             orderby c.Rating descending
                             select c;

                }
                if (BannedSort)
                {
                    result = from c in result.AsEnumerable()
                             orderby c.Banned descending
                             select c;
                }


                if (CommentDateSort)
                {
                    result = from c in result.AsEnumerable()
                             orderby c.CommentDate descending
                             select c;
                }

       

            }

            createview(result);
            sort = !sort;
        }

        private void btnCreateReply_Click(object sender, EventArgs e)
        {
            string txtReplyString = txtReply.Text;
            if (txtReplyString != "")
            {
                var CreateReply = new CommentReply { ReplyContent = txtReply.Text };
                this.dbContext.CommentReplies.Add(CreateReply);
                dbContext.SaveChanges();
            }
            else
            {
                MessageBox.Show("請輸入欲新增之回覆內容");
            }
            
            
        }

   

        private void cbxReply_Click(object sender, EventArgs e)
        {
            //this.cbxReply.DataSource = (from c in this.dbContext.CommentReplies.AsEnumerable()
            //                            select $"{c.CommentReplyID}.{c.ReplyContent}").ToList();

            this.cbxReply.DataSource = this.dbContext.CommentReplies.AsEnumerable().Select(c => $"{c.ReplyContent}").ToList();
        }

        private void btnDeleteReply_Click(object sender, EventArgs e)
        {
            int count = this.cbxReply.Items.Count;
            string cbxReplyString = cbxReply.Text;
       
            if ( count != 0 && cbxReplyString != "")
            {
               

                var DeleteReply = (from c in this.dbContext.CommentReplies.AsEnumerable()
                                   where c.ReplyContent.Contains(cbxReplyString)
                                   select c).FirstOrDefault();
                this.dbContext.CommentReplies.Remove(DeleteReply);
                dbContext.SaveChanges();

                this.cbxReply.DataSource = this.dbContext.CommentReplies.AsEnumerable().Select(c => $"{c.ReplyContent}").ToList();

            }
            else
            {
                MessageBox.Show("請選擇欲刪除之回覆或無資料可以刪除");
            }

        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            var result = createfilter();

            int CellID = (int)this.dgvComment.CurrentRow.Cells[0].Value;

            var q = from p in result
                    where p.CommentID == CellID
                    select p;

            foreach (var reply in q)
            {
                MessageBox.Show($"已回覆第{CellID}號評價");

                reply.ReplyContent = cbxReply.Text;
                reply.Reply = true;

            }
            this.dbContext.SaveChanges();


            createview(result);
        }

    }

}






