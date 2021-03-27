using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity
{
    public class SurveyEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdSuvey { get; set; }
        [Required]
        public DateTime CreateAt { get; set; }
        [Required]
        public DateTime DateEnd { get; set; }
        [StringLength(300 , ErrorMessage = "Descripcion de Encuesta Demasiado Larga")]
        public string Description { get; set; }
        //
        public string UserId { get; set; }
        public UserEntity User{ get; set; }

        public ICollection<QuestionEntity> Questions { get; set; }
        public ICollection<CategoryEntity> Categories { get; set; }
        public ICollection<AnswerEntity> Answers { get; set; }

    }
}
