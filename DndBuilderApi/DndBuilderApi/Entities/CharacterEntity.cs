using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DndBuilderApi.Entities
{
    [Table("Character", Schema = "dbo")]
    public class CharacterEntity
    {
        [Key]
        public int Id { get; set; }

        public int? Class { get; set; }
    }
}
