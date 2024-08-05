using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Minimum length of Title must be 5 characters.")]
        [MaxLength(200, ErrorMessage ="Maximum length of Title can't be over 200 characters.")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Minimum length of Content must be 5 characters.")]
        [MaxLength(200, ErrorMessage ="Maximum length of Content can't be over 200 characters.")]
        public string Content { get; set; } = string.Empty;
    }
}