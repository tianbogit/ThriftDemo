using System;
using System.Collections.Generic;
using System.Text;

namespace HelloThrift.Server
{
    public class MySchoolService : SchoolService.Iface
    {
        public school GetAllBanji()
        {
            return new school()
            {
                Age = 18,
                SchoolName = "学1",
                Zhuanye = new List<string>(),
                AllBanji = new List<banji>() {
                    new banji(){
                        BanjiName="班1",
                        AllStudents=new List<student>(){
                            new student(){
                                StudentName="student1",
                                Sex="1",
                                Age=18
                            }
                        }
                    }
                },

            };
        }
    }
}
