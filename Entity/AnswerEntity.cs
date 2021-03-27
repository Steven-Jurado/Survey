using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity
{
    public class AnswerEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string IdAnswer { get; set; }
        [Required]
        [StringLength(40 , ErrorMessage = "Respuesta  Es Mas de 40 Caracteres" )]
        public string GetAnswer { get; set; }
        [Required]
        public DateTime CreateAt { get; set; }

        //
        public string UserId { get; set; }
        public UserEntity User { get; set; }
        //
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
        //
        public string SurveyId { get; set; }
        public SurveyEntity Survey { get; set; }
    }
}
