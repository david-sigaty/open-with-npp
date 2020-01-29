using UnityEditor;
using TeamCitrus.Editor;

public class OpenWithNpp : OpenWithMenuItem
{
	public const string Name = "Notepad++";
	public const string Key = BaseKey + Name;
	public const string DefaultPath = "notepad++";
	private const string MenuItemPath = BasePath + Name;
	private const string EditMenuItemPath = EditPath + Name;
	
	[MenuItem(MenuItemPath, false, BasePriority)]
	public static void Open() { Execute<OpenWithNpp>(); }

	[MenuItem(MenuItemPath, true)]
	public static bool OpenValidation() { return Validate<OpenWithNpp>(); }
	
	[MenuItem(EditMenuItemPath, false, BasePriority + 51)]
	public static void EditOpen() { Execute<OpenWithNpp>(); }

	[MenuItem(EditMenuItemPath, true)]
	public static bool EditOpenValidation() { return Validate<OpenWithNpp>(); }
}
