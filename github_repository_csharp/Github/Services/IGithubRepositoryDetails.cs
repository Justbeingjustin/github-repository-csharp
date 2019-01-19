using Github.Models;

namespace Github.Services
{
    public interface IGithubRepository
    {
        GithubRepositoryDetails GetRepositoryDetails();
    }
}