using System.Windows.Forms;

public static class FormExtensions
{
    public static Form SetFormProperties(this Form form)
    {
        form.StartPosition = FormStartPosition.CenterScreen;
        form.ShowInTaskbar = true;

        return form;
    }

    public static Form SetFormProperties(this Form form, Form currentForm)
    {
        form.ShowInTaskbar = true;

        form.Height = currentForm.Height;
        form.Width = currentForm.Width;

        form.Size = currentForm.Size;
        form.StartPosition = FormStartPosition.Manual;
        form.Location = currentForm.Location;

        form.WindowState = currentForm.WindowState;

        return form;
    }

    public static Form SetDialogProperties(this Form form)
    {
        form.ShowInTaskbar = true;
        form.StartPosition = FormStartPosition.CenterScreen;

        return form;
    }
}