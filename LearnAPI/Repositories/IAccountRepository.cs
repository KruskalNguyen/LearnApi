using LearnAPI.ModelView;
using Microsoft.AspNetCore.Identity;

namespace LearnAPI.Repositories
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUp model);
        public Task<string> SignInAsync(SignIn model);
    }
}
