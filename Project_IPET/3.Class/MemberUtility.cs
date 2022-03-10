using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Web.Security;
using System.Text.RegularExpressions;

namespace Project_IPET
{
    class MemberUtility
    {
        #region References
        //private int _ID; private string _Name;
        //public int ID
        //{
        //    get
        //    {
        //        return _ID;
        //    }
        //    set
        //    {
        //        if (ID == 0)
        //            _ID = value;
        //    }
        //}
        //public string Name
        //{
        //    get
        //    {
        //        return _Name;
        //    }
        //    set
        //    {
        //        if(Name == null)
        //        _Name = value;
        //    }
        //}

        //public MemberEntities xxx(MemberEntities xxx)
        //{
        //    return xxx;
        //}
        #endregion

        #region 滑鼠Motion => 控制項變色事件
        public void ChangeMouseEnterColor(Control btn)
        {
            btn.BackColor = Color.PowderBlue;
        }
        public void ChangeMouseLeaveColor(Control btn)
        {
            btn.BackColor = Color.Transparent;
        }

        #endregion

        public static int MemberID;

        public static string UserID;

        public static string AdministratorID;

        //===============================
        MyProjectEntities dbContext = new MyProjectEntities();
        public void RegisterMemberShip()
        {
            //==========加鹽部分==========
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buf = new byte[15];
            rng.GetBytes(buf);
            string salt = Convert.ToBase64String(buf);

            //==========圖片轉 byte[]==========
            MemoryStream ms = new MemoryStream();
            GetMemberProfileToTemp.Avatar.Save(ms, ImageFormat.Png);
            byte[] bytes = ms.GetBuffer();

            //==========取得其他資料表資料==========
            var RegionID = (from r in this.dbContext.Regions
                            where r.RegionName == GetMemberProfileToTemp.Region
                            select r.RegionID).FirstOrDefault();

            //==========Create(Insert Into)==========
            Member member = new Member
            {
                UserID = GetMemberProfileToTemp.UserID,
                Password = FormsAuthentication.HashPasswordForStoringInConfigFile(GetMemberProfileToTemp.Password + salt, "sha1"),
                Salt = salt,
                Name = GetMemberProfileToTemp.Name,
                Email = GetMemberProfileToTemp.Email,
                Phone = GetMemberProfileToTemp.Phone,
                RegionID = RegionID,
                Address = GetMemberProfileToTemp.Address,
                Gender = GetMemberProfileToTemp.Gender,
                BirthDate = GetMemberProfileToTemp.BirthDate,
                RoleID = 1,
                Avatar = bytes,
                RegisteredDate = DateTime.Now
            };

            this.dbContext.Members.Add(member);
            this.dbContext.SaveChanges();
            MessageBox.Show("註冊完成,請點擊跳轉回登入畫面!");
        }

        public void EditMemberShip()
        {
            //==========加鹽部分==========
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buf = new byte[15];
            rng.GetBytes(buf);
            string salt = Convert.ToBase64String(buf);

            //==========圖片轉 byte[]==========
                MemoryStream ms = new MemoryStream();
                GetMemberProfileToTemp.Avatar.Save(ms, ImageFormat.Png);
                byte[] bytes = ms.GetBuffer();

            //==========取得其他資料表資料==========
            var RegionID = (from r in this.dbContext.Regions
                            where r.RegionName == GetMemberProfileToTemp.Region
                            select r.RegionID).FirstOrDefault();

            //==========Edit(Update)==========
            var members = (from m in this.dbContext.Members
                           where m.MemberID == MemberUtility.MemberID
                           select m).FirstOrDefault();

            members.UserID = GetMemberProfileToTemp.UserID;
            members.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(GetMemberProfileToTemp.Password + salt, "sha1");
            members.Salt = salt;
            members.Avatar = bytes;
            members.Name = GetMemberProfileToTemp.Name;
            members.BirthDate = GetMemberProfileToTemp.BirthDate;
            members.RegionID = RegionID;
            members.Address = GetMemberProfileToTemp.Address;
            members.Phone = GetMemberProfileToTemp.Phone;
            members.Email = GetMemberProfileToTemp.Email;

            this.dbContext.SaveChanges();
            MessageBox.Show("修改完成!");
        }
    }

    //會員資料暫存地
    public class GetMemberProfileToTemp
    {
        #region Regex 正規表達式
        static Regex rexUserID = new Regex(@"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$");
        #endregion
        //private static string _UserID;
        public static string UserID;
        //    {
        //        get
        //        {
        //            if (!rexUserID.IsMatch(_UserID)) return _UserID;
        //            else return "";
        //        }
        //        set
        //        {
        //            MessageBox.Show("wrong words");
        //        }
        //}
        public static string Password;
        //private static Image _Avatar;
        public static Image Avatar;
        //{
        //    get
        //    {
        //        if (_Avatar != null) return _Avatar;
        //        else return Image.FromFile(@"../../Picture/NFT 狗.png");
        //    }
        //    set
        //    {
        //        MessageBox.Show("pls browse picture");
        //    }

        //}
        public static string Name;
        public static int Gender;
        public static DateTime BirthDate;
        public static string Email;
        public static string Phone;
        public static string City;
        public static string Region;
        public static string Address;

        public static int whichRadioButton(object sender)
        {
            if (((RadioButton)sender).Checked == true)
            {
                return Gender = 1;
            }
            else
            {
                return Gender = 2;
            }
        }
    }
}