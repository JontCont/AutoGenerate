using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoGenerate.Models;
public interface IDBSchema
{
}

[Table("channl")]
public class Channl : IDBSchema
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("token")]
    [MaxLength(500)]
    public string? Token { get; set; }
    /// <summary>
    /// 金鑰
    /// </summary>
    [Column("prive_key")]
    [MaxLength(500)]
    public string? PriveKey { get; set; }

    [Column("create_date_time")]
    public DateTime CreateDateTime { get; set; }

    [Column("update_date_time")]
    public DateTime UpdateDateTime { get; set; }

}