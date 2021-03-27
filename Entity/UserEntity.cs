using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity
{
    public class UserEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string IdUser { get; set; }
        [Required ]
        [StringLength(40 , ErrorMessage = "Nombre Demasido Largo")]
        public string Name { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Apellido Demasido Largo")]
        public string LastName { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Correo Demasido Largo")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Apodo Demasido Largo")]
        public string NickName { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Contraseña Demasido Largo")]
        public string Password { get; set; }


        public ICollection<QuestionEntity> Questions { get; set; }
        public ICollection<AnswerEntity> Answers { get; set; }
        public ICollection<SurveyEntity> Surveys { get; set; }

    }
}
