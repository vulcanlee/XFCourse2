using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XFVerifyMessage.Helpers
{
    public class DataVerifyHelper
    {
        /// <summary>
        /// 檢查所傳入的文字是否為電子郵件
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public static bool Check電子郵件(string strIn)
        {
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        /// <summary>
        /// 檢查所傳入的文字，是否符合密碼符合使用者要求
        /// 至少八個字元，要包含 英文、數字、符號
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public static bool Check密碼(string strIn)
        {
            try
            {
                return Regex.IsMatch(strIn,
                      @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
