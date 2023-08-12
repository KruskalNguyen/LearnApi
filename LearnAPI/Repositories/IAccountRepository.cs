using LearnAPI.ModelView;
using Microsoft.AspNetCore.Identity;
using MyApiNetCore6.Data;

namespace LearnAPI.Repositories
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUp model);
        public Task<string> SignInAsync(SignIn model);
        public Task<List<ApplicationUser>> GetAllAccount();
    }
}
