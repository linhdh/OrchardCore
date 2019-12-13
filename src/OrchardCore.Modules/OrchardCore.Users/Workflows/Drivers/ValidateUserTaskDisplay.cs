using OrchardCore.Users.Workflows.Activities;
using OrchardCore.Users.Workflows.ViewModels;
using OrchardCore.Workflows.Display;

namespace OrchardCore.Users.Workflows.Drivers
{
    public class ValidateUserTaskDisplay : ActivityDisplayDriver<ValidateUserTask, ValidateUserTaskViewModel>
    {
        protected override void EditActivity(ValidateUserTask activity, ValidateUserTaskViewModel model)
        {
            model.Roles = activity.Roles;
            model.SetUser = activity.SetUser;
        }

        protected override void UpdateActivity(ValidateUserTaskViewModel model, ValidateUserTask activity)
        {
            activity.Roles = model.Roles;
            model.SetUser = activity.SetUser;
        }
    }
}