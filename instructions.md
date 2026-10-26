# Portfolio — Development Workflow

## 1. Access and clone

```bash
git clone https://github.com/EJConstantino-17/Portfolio.git
cd Portfolio
git fetch origin
git switch dev
git pull --ff-only
```

## 2. Branch navigation

| Action | Command |
| --- | --- |
| List local and remote branches | `git branch -a` |
| Refresh remote branch information | `git fetch origin` |
| Switch branch | `git switch <branch>` |
| Track a remote branch if needed | `git switch --track origin/<branch>` |
| Create and switch to a branch | `git switch -c feature/<name>` |
| Update the current branch | `git pull --ff-only` |

Save and commit your work before switching branches.

## 3. Start a feature from dev

```bash
git switch dev
git pull --ff-only
git switch -c feature/<name>
```

Do not develop directly on the shared branches.

## 4. Validate, commit, and push

Run the MVC app from its web project with `dotnet run` and check the affected pages/forms.

```bash
git add .
git commit -m "Add contact form"
git push -u origin feature/<name>
```

For later commits on the same branch, use `git push`.

## 5. Pull requests and promotion

On GitHub, open **Pull requests → New pull request**. **Base** receives the changes; **compare** supplies them.

| Step | Base | Compare | Purpose |
| --- | --- | --- | --- |
| Feature → development | `dev` | `feature/<name>` | Integrate completed work |
| Development → testing | `test` | `dev` | Verify integrated features |
| Testing → staging | `stage` | `test` | Check release readiness |
| Staging → release | `release` | `stage` | Approve the release candidate |
| Release → production | `main` | `release` | Publish production-ready code |
