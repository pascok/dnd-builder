using System.ComponentModel.DataAnnotations;
using DndBuilderApi.Entities;

namespace DndBuilderApi.Models
{
    public class Character
    {
        public Character(CharacterEntity entity)
        {
            Id = entity.Id;
            Class = entity.Class;
        }

        public Character() { }

        public int? Id { get; set; }
        
        public int? Class { get; set; }
    }
}
