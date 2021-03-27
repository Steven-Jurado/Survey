using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity
{
    public class QuestionEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdQuestions { get; set; }
        [Required]
        [StringLength(40 , ErrorMessage ="Pregunta Demasiado Larga")]
        public string GetQuestion { get; set; }
        [Required]
        public DateTime CreateAt { get; set; }


        //Relacion De Muchos
        //
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
        //
        public string UserId { get; set; }
        public UserEntity User { get; set; }
        //
        public string SurveyId { get; set; }
        public SurveyEntity Survey { get; set; }

    }
}
