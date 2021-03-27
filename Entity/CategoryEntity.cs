using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity
{
    public class CategoryEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string IdCategory { get; set; }
        [Required]
        [StringLength(40 ,ErrorMessage = "Nombre de Categoria Es Mas de 40 Caracteres")]
        public string NameCategory { get; set; }
        [Required]
        public DateTime CreateAt { get; set; }

        //

        public string SurveyId { get; set; }
        public SurveyEntity Survey { get; set; }
        //

        public ICollection<QuestionEntity> Questions { get; set; }
        public ICollection<AnswerEntity> Answers { get; set; }

    }
}
