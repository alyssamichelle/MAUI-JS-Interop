using System;

namespace MAUI_Blazor
{
	public class DialogService : IDialogService
	{
		public DialogService()
		{
		}

        public async Task<bool> DisplayConfirm(string title, string message, string accept, string cancel)
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }

    }
}

