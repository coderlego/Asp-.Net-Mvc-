using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ValidationRules
{
    public class AdminValidator: AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(x => x.AdminUserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez");
            RuleFor(x => x.AdminPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez");
            RuleFor(x => x.AdminUserName).MinimumLength(3).WithMessage("Kullanıcı Adı 3 karakterden büyük olmalı");
            RuleFor(x => x.AdminUserName).MaximumLength(30).WithMessage("Kullanıcı Adı 30 karakterden küçük olmalı");
            RuleFor(x => x.AdminPassword).MinimumLength(3).WithMessage("Şifre 3 Karakterden Büyük Olmalı");
            RuleFor(x => x.AdminPassword).MaximumLength(12).WithMessage("Şifre 12 Karakterden Küçük Olmalı");

        }
    }
}
