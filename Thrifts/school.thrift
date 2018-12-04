namespace cpp example
include "banji.thrift" 
struct school {
    1:required string schoolName,
    2:required i64    age,
    3:required list<string> zhuanye, #所有专业
    4:required list<banji.banji> allBanji, #所有班级
}