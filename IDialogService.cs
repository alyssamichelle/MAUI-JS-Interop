using System;
namespace MAUI_Blazor
{
	public interface IDialogService
	{
		Task<bool> DisplayConfirm(string title, string message, string accept, string cancel);
	}
}

