using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ken.Test.Web.Models
{
    // 创建user表对应实体类
    [Table("user")]
    [Serializable]
    public class UserEntity
    {
        [Key] //主键
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //自增列
        [Column("id")]
        public int ID { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("age")]
        public int age { get; set; }

        [Column("hobby")]
        public string hobby { get; set; }
    }
}
