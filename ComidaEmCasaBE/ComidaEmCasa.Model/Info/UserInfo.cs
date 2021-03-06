using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComidaEmCasa.Model.Info
{
    public class UserInfo : BaseInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Cellphone { get; set; }
    }
}
