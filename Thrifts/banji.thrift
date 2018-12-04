namespace cpp example
include "student.thrift" 
struct banji{
    1:required string banjiName, #班级名称
    2:required list<student.student> allStudents, #所有学生
}