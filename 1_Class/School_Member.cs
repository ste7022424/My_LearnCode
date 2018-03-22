using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Class
{
    class School_Member
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name;
        /// <summary>
        /// 年紀
        /// </summary>
        public int Age;
        /// <summary>
        /// 年級
        /// </summary>
        public int Grade;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="Default_Name"></param>
        /// <param name="Default_Age"></param>
        /// <param name="Default_Grade"></param>
        public School_Member(string Default_Name,int Default_Age,int Default_Grade) {
            Name = Default_Name;
            Age = Default_Age;
            Grade = Default_Grade;

        }

        /// <summary>
        /// 介紹自己
        /// </summary>
        /// <returns>String</returns>
        public string AboutYourSelf()
        {
            return "你好，我叫" + Name + ",我目前" + Age + "歲," + Grade + "年級";
        }
    }
}
