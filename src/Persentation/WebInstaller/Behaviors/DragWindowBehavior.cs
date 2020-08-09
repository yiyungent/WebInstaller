using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace WebInstaller.Behaviors
{
    public class DragWindowBehavior : Behavior<FrameworkElement>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.MouseDown += AssociatedObjectOnMouseDown;
        }

        private void AssociatedObjectOnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                Window.GetWindow(AssociatedObject)?.DragMove();
        }
    }
}