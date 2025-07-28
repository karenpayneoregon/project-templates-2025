#pragma warning disable CS8602 // Dereference of a possibly null reference.
namespace WindowsForms2025.Controls
{
    /// <summary>
    /// Represents a custom implementation of the <see cref="BindingNavigator"/> control, 
    /// providing additional functionality such as enabling or disabling buttons, 
    /// removing default handlers, and managing visibility of custom items.
    /// </summary>
    /// <remarks>
    /// The <see cref="BindingNavigator"/> control is not available natively starting with VS2019 for .NET Core. 
    /// This class provides a custom implementation to address this limitation.
    /// </remarks>
    public sealed class CoreBindingNavigator : BindingNavigator
    {
        public CoreBindingNavigator()
        {
            AddStandardItems();

            Items.Add(new ToolStripSeparator());
            Items.Add(new ToolStripButton() { Name = "bindingNavigatorAboutItem", Text = "About"});

            BackColor = Color.Cornsilk;
        }

        /// <summary>
        /// Set Enable for add button
        /// </summary>
        public void AddButtonEnable(bool enable = false)
        {
            AddNewItem.Enabled = enable;
        }

        /// <summary>
        /// Set Enable for delete button
        /// </summary>
        public void RemoveButtonEnable(bool enable = false)
        {
            DeleteItem.Enabled = enable;
        }
        
        /// <summary>
        /// Remove default actions for delete and add buttons
        /// </summary>
        public void RemoveDefaultHandlers()
        {
            AddNewItem = null;
            DeleteItem = null;
        }

        /// <summary>
        /// Hide about button
        /// </summary>
        public void HideAboutButton()
        {
            AboutItemButton.Visible = false;
        }

        /// <summary>
        /// Show about button
        /// </summary>
        public void ShowAboutButton()
        {
            AboutItemButton.Visible = true;
        }


        /// <summary>
        /// Provide access to the add new button
        /// </summary>
        public ToolStripItem AddItemButton => Items["bindingNavigatorAddNewItem"]!;
        /// <summary>
        /// Provides access to the delete current row
        /// </summary>
        public ToolStripItem DeleteItemButton => Items["bindingNavigatorDeleteItem"]!;
        public ToolStripItem AboutItemButton => Items["bindingNavigatorAboutItem"]!;
    }
}
