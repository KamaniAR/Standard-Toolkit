#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner (aka Wagnerp), Simon Coghlan (aka Smurf-IV), Giduac & Ahmed Abdelhameed, tobitege et al. 2025 - 2025. All rights reserved.
 *
 */
#endregion

namespace Krypton.Toolkit;

/// <summary>
/// Defines the base abstract class for Krypton color schemes, providing a comprehensive set of color properties 
/// for customizing the appearance of various UI elements in the Krypton Toolkit.
/// </summary>
/// <remarks>
/// This base class serves as a foundation for implementing specific color schemes by defining all required colors
/// for the Krypton UI components. It includes colors for:
/// - Button states and appearances
/// - Form elements and borders
/// - Ribbon control elements
/// - Navigation elements
/// - Header and panel appearances
/// - Input controls
/// - Menu items and context menus
/// - Grid and list views
/// - Various UI element states (normal, pressed, selected, disabled)
/// </remarks>
public abstract class KryptonColorSchemeBase
{
    #region Variables

    /// <summary>Gets or sets the text color for standard control labels.</summary>
    public abstract Color TextLabelControl { get; set; }

    /// <summary>Gets or sets the text color for buttons in their normal state.</summary>
    public abstract Color TextButtonNormal { get; set; }

    /// <summary>Gets or sets the text color for buttons in their checked state.</summary>
    public abstract Color TextButtonChecked { get; set; }

    /// <summary>Gets or sets the border color for buttons in their normal state.</summary>
    public abstract Color ButtonNormalBorder { get; set; }

    /// <summary>Gets or sets the default border color for buttons in their normal state.</summary>
    public abstract Color ButtonNormalDefaultBorder { get; set; }

    /// <summary>Gets or sets the primary background color for buttons in their normal state.</summary>
    public abstract Color ButtonNormalBack1 { get; set; }

    /// <summary>Gets or sets the secondary background color for buttons in their normal state.</summary>
    public abstract Color ButtonNormalBack2 { get; set; }

    /// <summary>Gets or sets the primary background color for default buttons in their normal state.</summary>
    public abstract Color ButtonNormalDefaultBack1 { get; set; }

    /// <summary>Gets or sets the secondary background color for default buttons in their normal state.</summary>
    public abstract Color ButtonNormalDefaultBack2 { get; set; }

    /// <summary>Gets or sets the primary background color for navigator buttons in their normal state.</summary>
    public abstract Color ButtonNormalNavigatorBack1 { get; set; }

    /// <summary>Gets or sets the secondary background color for navigator buttons in their normal state.</summary>
    public abstract Color ButtonNormalNavigatorBack2 { get; set; }

    /// <summary>Gets or sets the background color for standard client panels.</summary>
    public abstract Color PanelClient { get; set; }

    /// <summary>Gets or sets the background color for alternative panels.</summary>
    public abstract Color PanelAlternative { get; set; }

    /// <summary>Gets or sets the color used for control borders.</summary>
    public abstract Color ControlBorder { get; set; }

    /// <summary>Gets or sets the primary color for high-emphasis separators.</summary>
    public abstract Color SeparatorHighBorder1 { get; set; }

    /// <summary>Gets or sets the secondary color for high-emphasis separators.</summary>
    public abstract Color SeparatorHighBorder2 { get; set; }

    /// <summary>Gets or sets the primary background color for primary headers.</summary>
    public abstract Color HeaderPrimaryBack1 { get; set; }

    /// <summary>Gets or sets the secondary background color for primary headers.</summary>
    public abstract Color HeaderPrimaryBack2 { get; set; }

    /// <summary>Gets or sets the primary background color for secondary headers.</summary>
    public abstract Color HeaderSecondaryBack1 { get; set; }

    /// <summary>Gets or sets the secondary background color for secondary headers.</summary>
    public abstract Color HeaderSecondaryBack2 { get; set; }

    /// <summary>Gets or sets the text color for headers.</summary>
    public abstract Color HeaderText { get; set; }

    /// <summary>Gets or sets the text color for status strips.</summary>
    public abstract Color StatusStripText { get; set; }

    /// <summary>Gets or sets the color used for button borders.</summary>
    public abstract Color ButtonBorder { get; set; }

    /// <summary>Gets or sets the color for light separators.</summary>
    public abstract Color SeparatorLight { get; set; }

    /// <summary>Gets or sets the color for dark separators.</summary>
    public abstract Color SeparatorDark { get; set; }

    /// <summary>Gets or sets the color for light grip elements (such as window resizers).</summary>
    public abstract Color GripLight { get; set; }

    /// <summary>Gets or sets the color for dark grip elements (such as window resizers).</summary>
    public abstract Color GripDark { get; set; }

    /// <summary>Gets or sets the background color for tool strips.</summary>
    public abstract Color ToolStripBack { get; set; }

    /// <summary>Gets or sets the light color for status strips.</summary>
    public abstract Color StatusStripLight { get; set; }

    /// <summary>Gets or sets the dark color for status strips.</summary>
    public abstract Color StatusStripDark { get; set; }

    /// <summary>Gets or sets the color for image margins in menus and tool strips.</summary>
    public abstract Color ImageMargin { get; set; }

    /// <summary>Gets or sets the starting color for tool strip gradients.</summary>
    public abstract Color ToolStripBegin { get; set; }

    /// <summary>Gets or sets the middle color for tool strip gradients.</summary>
    public abstract Color ToolStripMiddle { get; set; }

    /// <summary>Gets or sets the ending color for tool strip gradients.</summary>
    public abstract Color ToolStripEnd { get; set; }

    /// <summary>Gets or sets the starting color for overflow gradients in tool strips.</summary>
    public abstract Color OverflowBegin { get; set; }

    /// <summary>Gets or sets the middle color for overflow gradients in tool strips.</summary>
    public abstract Color OverflowMiddle { get; set; }

    /// <summary>Gets or sets the ending color for overflow gradients in tool strips.</summary>
    public abstract Color OverflowEnd { get; set; }

    /// <summary>Gets or sets the border color for tool strips.</summary>
    public abstract Color ToolStripBorder { get; set; }

    /// <summary>Gets or sets the color for active form borders.</summary>
    public abstract Color FormBorderActive { get; set; }

    /// <summary>Gets or sets the color for inactive form borders.</summary>
    public abstract Color FormBorderInactive { get; set; }

    /// <summary>Gets or sets the light color for active form borders.</summary>
    public abstract Color FormBorderActiveLight { get; set; }

    /// <summary>Gets or sets the dark color for active form borders.</summary>
    public abstract Color FormBorderActiveDark { get; set; }

    /// <summary>Gets or sets the light color for inactive form borders.</summary>
    public abstract Color FormBorderInactiveLight { get; set; }

    /// <summary>Gets or sets the dark color for inactive form borders.</summary>
    public abstract Color FormBorderInactiveDark { get; set; }

    /// <summary>Gets or sets the color for active form header borders.</summary>
    public abstract Color FormBorderHeaderActive { get; set; }

    /// <summary>Gets or sets the color for inactive form header borders.</summary>
    public abstract Color FormBorderHeaderInactive { get; set; }

    /// <summary>Gets or sets the first color for active form header borders.</summary>
    public abstract Color FormBorderHeaderActive1 { get; set; }

    /// <summary>Gets or sets the second color for active form header borders.</summary>
    public abstract Color FormBorderHeaderActive2 { get; set; }

    /// <summary>Gets or sets the first color for inactive form header borders.</summary>
    public abstract Color FormBorderHeaderInactive1 { get; set; }

    /// <summary>Gets or sets the second color for inactive form header borders.</summary>
    public abstract Color FormBorderHeaderInactive2 { get; set; }

    /// <summary>Gets or sets the color for short active form headers.</summary>
    public abstract Color FormHeaderShortActive { get; set; }

    /// <summary>Gets or sets the color for short inactive form headers.</summary>
    public abstract Color FormHeaderShortInactive { get; set; }

    /// <summary>Gets or sets the color for long active form headers.</summary>
    public abstract Color FormHeaderLongActive { get; set; }

    /// <summary>Gets or sets the color for long inactive form headers.</summary>
    public abstract Color FormHeaderLongInactive { get; set; }

    /// <summary>Gets or sets the border color for form buttons when tracking (hovered).</summary>
    public abstract Color FormButtonBorderTrack { get; set; }

    /// <summary>Gets or sets the primary background color for form buttons when tracking (hovered).</summary>
    public abstract Color FormButtonBack1Track { get; set; }

    /// <summary>Gets or sets the secondary background color for form buttons when tracking (hovered).</summary>
    public abstract Color FormButtonBack2Track { get; set; }

    /// <summary>Gets or sets the border color for form buttons when pressed.</summary>
    public abstract Color FormButtonBorderPressed { get; set; }

    /// <summary>Gets or sets the primary background color for form buttons when pressed.</summary>
    public abstract Color FormButtonBack1Pressed { get; set; }

    /// <summary>Gets or sets the secondary background color for form buttons when pressed.</summary>
    public abstract Color FormButtonBack2Pressed { get; set; }

    /// <summary>Gets or sets the text color for form buttons in their normal state.</summary>
    public abstract Color TextButtonFormNormal { get; set; }

    /// <summary>Gets or sets the text color for form buttons when tracking (hovered).</summary>
    public abstract Color TextButtonFormTracking { get; set; }

    /// <summary>Gets or sets the text color for form buttons when pressed.</summary>
    public abstract Color TextButtonFormPressed { get; set; }

    /// <summary>Gets or sets the color for unvisited links on controls.</summary>
    public abstract Color LinkNotVisitedOverrideControl { get; set; }

    /// <summary>Gets or sets the color for visited links on controls.</summary>
    public abstract Color LinkVisitedOverrideControl { get; set; }

    /// <summary>Gets or sets the color for pressed links on controls.</summary>
    public abstract Color LinkPressedOverrideControl { get; set; }

    /// <summary>Gets or sets the color for unvisited links on panels.</summary>
    public abstract Color LinkNotVisitedOverridePanel { get; set; }

    /// <summary>Gets or sets the color for visited links on panels.</summary>
    public abstract Color LinkVisitedOverridePanel { get; set; }

    /// <summary>Gets or sets the color for pressed links on panels.</summary>
    public abstract Color LinkPressedOverridePanel { get; set; }

    /// <summary>Gets or sets the text color for labels on panels.</summary>
    public abstract Color TextLabelPanel { get; set; }

    /// <summary>Gets or sets the text color for ribbon tabs in their normal state.</summary>
    public abstract Color RibbonTabTextNormal { get; set; }

    /// <summary>Gets or sets the text color for ribbon tabs when checked.</summary>
    public abstract Color RibbonTabTextChecked { get; set; }

    /// <summary>Gets or sets the first background color for selected ribbon tabs.</summary>
    public abstract Color RibbonTabSelected1 { get; set; }

    /// <summary>Gets or sets the second background color for selected ribbon tabs.</summary>
    public abstract Color RibbonTabSelected2 { get; set; }

    /// <summary>Gets or sets the third background color for selected ribbon tabs.</summary>
    public abstract Color RibbonTabSelected3 { get; set; }

    /// <summary>Gets or sets the fourth background color for selected ribbon tabs.</summary>
    public abstract Color RibbonTabSelected4 { get; set; }

    /// <summary>Gets or sets the fifth background color for selected ribbon tabs.</summary>
    public abstract Color RibbonTabSelected5 { get; set; }

    /// <summary>Gets or sets the first background color for ribbon tabs when tracking (hovered).</summary>
    public abstract Color RibbonTabTracking1 { get; set; }

    /// <summary>Gets or sets the second background color for ribbon tabs when tracking (hovered).</summary>
    public abstract Color RibbonTabTracking2 { get; set; }

    /// <summary>Gets or sets the first highlight color for ribbon tabs.</summary>
    public abstract Color RibbonTabHighlight1 { get; set; }

    /// <summary>Gets or sets the second highlight color for ribbon tabs.</summary>
    public abstract Color RibbonTabHighlight2 { get; set; }

    /// <summary>Gets or sets the third highlight color for ribbon tabs.</summary>
    public abstract Color RibbonTabHighlight3 { get; set; }

    /// <summary>Gets or sets the fourth highlight color for ribbon tabs.</summary>
    public abstract Color RibbonTabHighlight4 { get; set; }

    /// <summary>Gets or sets the fifth highlight color for ribbon tabs.</summary>
    public abstract Color RibbonTabHighlight5 { get; set; }

    /// <summary>Gets or sets the color for the separator between ribbon tabs.</summary>
    public abstract Color RibbonTabSeparatorColor { get; set; }

    /// <summary>Gets or sets the first background color for the ribbon groups area.</summary>
    public abstract Color RibbonGroupsArea1 { get; set; }

    /// <summary>Gets or sets the second background color for the ribbon groups area.</summary>
    public abstract Color RibbonGroupsArea2 { get; set; }

    /// <summary>Gets or sets the third background color for the ribbon groups area.</summary>
    public abstract Color RibbonGroupsArea3 { get; set; }

    /// <summary>Gets or sets the fourth background color for the ribbon groups area.</summary>
    public abstract Color RibbonGroupsArea4 { get; set; }

    /// <summary>Gets or sets the fifth background color for the ribbon groups area.</summary>
    public abstract Color RibbonGroupsArea5 { get; set; }

    /// <summary>Gets or sets the first border color for ribbon groups.</summary>
    public abstract Color RibbonGroupBorder1 { get; set; }

    /// <summary>Gets or sets the second border color for ribbon groups.</summary>
    public abstract Color RibbonGroupBorder2 { get; set; }

    /// <summary>Gets or sets the first title color for ribbon groups.</summary>
    public abstract Color RibbonGroupTitle1 { get; set; }

    /// <summary>Gets or sets the second title color for ribbon groups.</summary>
    public abstract Color RibbonGroupTitle2 { get; set; }

    /// <summary>Gets or sets the first context border color for ribbon groups.</summary>
    public abstract Color RibbonGroupBorderContext1 { get; set; }

    /// <summary>Gets or sets the second context border color for ribbon groups.</summary>
    public abstract Color RibbonGroupBorderContext2 { get; set; }

    /// <summary>Gets or sets the first context title color for ribbon groups.</summary>
    public abstract Color RibbonGroupTitleContext1 { get; set; }

    /// <summary>Gets or sets the second context title color for ribbon groups.</summary>
    public abstract Color RibbonGroupTitleContext2 { get; set; }

    /// <summary>Gets or sets the dark color for the ribbon group dialog launcher.</summary>
    public abstract Color RibbonGroupDialogDark { get; set; }

    /// <summary>Gets or sets the light color for the ribbon group dialog launcher.</summary>
    public abstract Color RibbonGroupDialogLight { get; set; }

    /// <summary>Gets or sets the first tracking color for ribbon group titles.</summary>
    public abstract Color RibbonGroupTitleTracking1 { get; set; }

    /// <summary>Gets or sets the second tracking color for ribbon group titles.</summary>
    public abstract Color RibbonGroupTitleTracking2 { get; set; }

    /// <summary>Gets or sets the dark color for the ribbon minimize bar.</summary>
    public abstract Color RibbonMinimizeBarDark { get; set; }

    /// <summary>Gets or sets the light color for the ribbon minimize bar.</summary>
    public abstract Color RibbonMinimizeBarLight { get; set; }

    /// <summary>Gets or sets the first border color for collapsed ribbon groups.</summary>
    public abstract Color RibbonGroupCollapsedBorder1 { get; set; }

    /// <summary>Gets or sets the second border color for collapsed ribbon groups.</summary>
    public abstract Color RibbonGroupCollapsedBorder2 { get; set; }

    /// <summary>Gets or sets the third border color for collapsed ribbon groups.</summary>
    public abstract Color RibbonGroupCollapsedBorder3 { get; set; }

    /// <summary>Gets or sets the fourth border color for collapsed ribbon groups.</summary>
    public abstract Color RibbonGroupCollapsedBorder4 { get; set; }

    /// <summary>Gets or sets the first background color for collapsed ribbon groups.</summary>
    public abstract Color RibbonGroupCollapsedBack1 { get; set; }

    /// <summary>Gets or sets the second background color for collapsed ribbon groups.</summary>
    public abstract Color RibbonGroupCollapsedBack2 { get; set; }

    /// <summary>Gets or sets the third background color for collapsed ribbon groups.</summary>
    public abstract Color RibbonGroupCollapsedBack3 { get; set; }

    /// <summary>Gets or sets the fourth background color for collapsed ribbon groups.</summary>
    public abstract Color RibbonGroupCollapsedBack4 { get; set; }
    /// <summary>Gets or sets the first border color for collapsed ribbon groups in tracking state.</summary>
    public abstract Color RibbonGroupCollapsedBorderT1 { get; set; }

    /// <summary>Gets or sets the second border color for collapsed ribbon groups in tracking state.</summary>
    public abstract Color RibbonGroupCollapsedBorderT2 { get; set; }

    /// <summary>Gets or sets the third border color for collapsed ribbon groups in tracking state.</summary>
    public abstract Color RibbonGroupCollapsedBorderT3 { get; set; }

    /// <summary>Gets or sets the fourth border color for collapsed ribbon groups in tracking state.</summary>
    public abstract Color RibbonGroupCollapsedBorderT4 { get; set; }

    /// <summary>Gets or sets the first background color for collapsed ribbon groups in tracking state.</summary>
    public abstract Color RibbonGroupCollapsedBackT1 { get; set; }

    /// <summary>Gets or sets the second background color for collapsed ribbon groups in tracking state.</summary>
    public abstract Color RibbonGroupCollapsedBackT2 { get; set; }

    /// <summary>Gets or sets the third background color for collapsed ribbon groups in tracking state.</summary>
    public abstract Color RibbonGroupCollapsedBackT3 { get; set; }

    /// <summary>Gets or sets the fourth background color for collapsed ribbon groups in tracking state.</summary>
    public abstract Color RibbonGroupCollapsedBackT4 { get; set; }

    /// <summary>Gets or sets the first border color for the ribbon group frame.</summary>
    public abstract Color RibbonGroupFrameBorder1 { get; set; }

    /// <summary>Gets or sets the second border color for the ribbon group frame.</summary>
    public abstract Color RibbonGroupFrameBorder2 { get; set; }

    /// <summary>Gets or sets the first inside color for the ribbon group frame.</summary>
    public abstract Color RibbonGroupFrameInside1 { get; set; }

    /// <summary>Gets or sets the second inside color for the ribbon group frame.</summary>
    public abstract Color RibbonGroupFrameInside2 { get; set; }

    /// <summary>Gets or sets the third inside color for the ribbon group frame.</summary>
    public abstract Color RibbonGroupFrameInside3 { get; set; }

    /// <summary>Gets or sets the fourth inside color for the ribbon group frame.</summary>
    public abstract Color RibbonGroupFrameInside4 { get; set; }

    /// <summary>Gets or sets the text color for collapsed ribbon groups.</summary>
    public abstract Color RibbonGroupCollapsedText { get; set; }

    /// <summary>Gets or sets the text color for ribbon group buttons.</summary>
    public abstract Color RibbonGroupButtonText { get; set; }

    /// <summary>Gets or sets the primary background color for alternate pressed states.</summary>
    public abstract Color AlternatePressedBack1 { get; set; }

    /// <summary>Gets or sets the secondary background color for alternate pressed states.</summary>
    public abstract Color AlternatePressedBack2 { get; set; }

    /// <summary>Gets or sets the primary border color for alternate pressed states.</summary>
    public abstract Color AlternatePressedBorder1 { get; set; }

    /// <summary>Gets or sets the secondary border color for alternate pressed states.</summary>
    public abstract Color AlternatePressedBorder2 { get; set; }

    /// <summary>Gets or sets the primary background color for checked form buttons.</summary>
    public abstract Color FormButtonBack1Checked { get; set; }

    /// <summary>Gets or sets the secondary background color for checked form buttons.</summary>
    public abstract Color FormButtonBack2Checked { get; set; }

    /// <summary>Gets or sets the border color for checked form buttons.</summary>
    public abstract Color FormButtonBorderCheck { get; set; }

    /// <summary>Gets or sets the primary background color for checked form buttons in tracking state.</summary>
    public abstract Color FormButtonBack1CheckTrack { get; set; }

    /// <summary>Gets or sets the secondary background color for checked form buttons in tracking state.</summary>
    public abstract Color FormButtonBack2CheckTrack { get; set; }

    /// <summary>Gets or sets the first color for the Quick Access Toolbar (QAT) mini button.</summary>
    public abstract Color RibbonQATMini1 { get; set; }

    /// <summary>Gets or sets the second color for the Quick Access Toolbar (QAT) mini button.</summary>
    public abstract Color RibbonQATMini2 { get; set; }

    /// <summary>Gets or sets the third color for the Quick Access Toolbar (QAT) mini button.</summary>
    public abstract Color RibbonQATMini3 { get; set; }

    /// <summary>Gets or sets the fourth color for the Quick Access Toolbar (QAT) mini button.</summary>
    public abstract Color RibbonQATMini4 { get; set; }

    /// <summary>Gets or sets the fifth color for the Quick Access Toolbar (QAT) mini button.</summary>
    public abstract Color RibbonQATMini5 { get; set; }

    /// <summary>Gets or sets the first color for the Quick Access Toolbar (QAT) mini button (inactive state).</summary>
    public abstract Color RibbonQATMini1I { get; set; }

    /// <summary>Gets or sets the second color for the Quick Access Toolbar (QAT) mini button (inactive state).</summary>
    public abstract Color RibbonQATMini2I { get; set; }

    /// <summary>Gets or sets the third color for the Quick Access Toolbar (QAT) mini button (inactive state).</summary>
    public abstract Color RibbonQATMini3I { get; set; }

    /// <summary>Gets or sets the fourth color for the Quick Access Toolbar (QAT) mini button (inactive state).</summary>
    public abstract Color RibbonQATMini4I { get; set; }

    /// <summary>Gets or sets the fifth color for the Quick Access Toolbar (QAT) mini button (inactive state).</summary>
    public abstract Color RibbonQATMini5I { get; set; }

    /// <summary>Gets or sets the first color for the Quick Access Toolbar (QAT) full bar.</summary>
    public abstract Color RibbonQATFullbar1 { get; set; }

    /// <summary>Gets or sets the second color for the Quick Access Toolbar (QAT) full bar.</summary>
    public abstract Color RibbonQATFullbar2 { get; set; }

    /// <summary>Gets or sets the third color for the Quick Access Toolbar (QAT) full bar.</summary>
    public abstract Color RibbonQATFullbar3 { get; set; }

    /// <summary>Gets or sets the dark color for the Quick Access Toolbar (QAT) button.</summary>
    public abstract Color RibbonQATButtonDark { get; set; }

    /// <summary>Gets or sets the light color for the Quick Access Toolbar (QAT) button.</summary>
    public abstract Color RibbonQATButtonLight { get; set; }

    /// <summary>Gets or sets the first color for the Quick Access Toolbar (QAT) overflow area.</summary>
    public abstract Color RibbonQATOverflow1 { get; set; }

    /// <summary>Gets or sets the second color for the Quick Access Toolbar (QAT) overflow area.</summary>
    public abstract Color RibbonQATOverflow2 { get; set; }
    /// <summary>Gets or sets the dark color for ribbon group separators.</summary>
    public abstract Color RibbonGroupSeparatorDark { get; set; }

    /// <summary>Gets or sets the light color for ribbon group separators.</summary>
    public abstract Color RibbonGroupSeparatorLight { get; set; }

    /// <summary>Gets or sets the primary background color for button cluster buttons.</summary>
    public abstract Color ButtonClusterButtonBack1 { get; set; }

    /// <summary>Gets or sets the secondary background color for button cluster buttons.</summary>
    public abstract Color ButtonClusterButtonBack2 { get; set; }

    /// <summary>Gets or sets the primary border color for button cluster buttons.</summary>
    public abstract Color ButtonClusterButtonBorder1 { get; set; }

    /// <summary>Gets or sets the secondary border color for button cluster buttons.</summary>
    public abstract Color ButtonClusterButtonBorder2 { get; set; }

    /// <summary>Gets or sets the background color for the mini navigator control.</summary>
    public abstract Color NavigatorMiniBackColor { get; set; }

    /// <summary>Gets or sets the primary background color for grid list items in their normal state.</summary>
    public abstract Color GridListNormal1 { get; set; }

    /// <summary>Gets or sets the secondary background color for grid list items in their normal state.</summary>
    public abstract Color GridListNormal2 { get; set; }

    /// <summary>Gets or sets the primary background color for grid list items when pressed.</summary>
    public abstract Color GridListPressed1 { get; set; }

    /// <summary>Gets or sets the secondary background color for grid list items when pressed.</summary>
    public abstract Color GridListPressed2 { get; set; }

    /// <summary>Gets or sets the background color for grid list items when selected.</summary>
    public abstract Color GridListSelected { get; set; }

    /// <summary>Gets or sets the primary background color for grid sheet columns in their normal state.</summary>
    public abstract Color GridSheetColNormal1 { get; set; }

    /// <summary>Gets or sets the secondary background color for grid sheet columns in their normal state.</summary>
    public abstract Color GridSheetColNormal2 { get; set; }

    /// <summary>Gets or sets the primary background color for grid sheet columns when pressed.</summary>
    public abstract Color GridSheetColPressed1 { get; set; }

    /// <summary>Gets or sets the secondary background color for grid sheet columns when pressed.</summary>
    public abstract Color GridSheetColPressed2 { get; set; }

    /// <summary>Gets or sets the primary background color for grid sheet columns when selected.</summary>
    public abstract Color GridSheetColSelected1 { get; set; }

    /// <summary>Gets or sets the secondary background color for grid sheet columns when selected.</summary>
    public abstract Color GridSheetColSelected2 { get; set; }

    /// <summary>Gets or sets the background color for grid sheet rows in their normal state.</summary>
    public abstract Color GridSheetRowNormal { get; set; }

    /// <summary>Gets or sets the background color for grid sheet rows when pressed.</summary>
    public abstract Color GridSheetRowPressed { get; set; }

    /// <summary>Gets or sets the background color for grid sheet rows when selected.</summary>
    public abstract Color GridSheetRowSelected { get; set; }

    /// <summary>Gets or sets the border color for grid data cells.</summary>
    public abstract Color GridDataCellBorder { get; set; }

    /// <summary>Gets or sets the background color for selected grid data cells.</summary>
    public abstract Color GridDataCellSelected { get; set; }

    /// <summary>Gets or sets the text color for input controls in their normal state.</summary>
    public abstract Color InputControlTextNormal { get; set; }

    /// <summary>Gets or sets the text color for input controls when disabled.</summary>
    public abstract Color InputControlTextDisabled { get; set; }

    /// <summary>Gets or sets the border color for input controls in their normal state.</summary>
    public abstract Color InputControlBorderNormal { get; set; }

    /// <summary>Gets or sets the border color for input controls when disabled.</summary>
    public abstract Color InputControlBorderDisabled { get; set; }

    /// <summary>Gets or sets the background color for input controls in their normal state.</summary>
    public abstract Color InputControlBackNormal { get; set; }

    /// <summary>Gets or sets the background color for input controls when disabled.</summary>
    public abstract Color InputControlBackDisabled { get; set; }

    /// <summary>Gets or sets the background color for input controls when inactive.</summary>
    public abstract Color InputControlBackInactive { get; set; }

    /// <summary>Gets or sets the primary background color for input dropdowns in their normal state.</summary>
    public abstract Color InputDropDownNormal1 { get; set; }

    /// <summary>Gets or sets the secondary background color for input dropdowns in their normal state.</summary>
    public abstract Color InputDropDownNormal2 { get; set; }

    /// <summary>Gets or sets the primary background color for input dropdowns when disabled.</summary>
    public abstract Color InputDropDownDisabled1 { get; set; }

    /// <summary>Gets or sets the secondary background color for input dropdowns when disabled.</summary>
    public abstract Color InputDropDownDisabled2 { get; set; }

    /// <summary>Gets or sets the background color for context menu headings.</summary>
    public abstract Color ContextMenuHeadingBack { get; set; }

    /// <summary>Gets or sets the text color for context menu headings.</summary>
    public abstract Color ContextMenuHeadingText { get; set; }

    /// <summary>Gets or sets the color for the image column in context menus.</summary>
    public abstract Color ContextMenuImageColumn { get; set; }

    /// <summary>Gets or sets the primary background color for the application button.</summary>
    public abstract Color AppButtonBack1 { get; set; }

    /// <summary>Gets or sets the secondary background color for the application button.</summary>
    public abstract Color AppButtonBack2 { get; set; }

    /// <summary>Gets or sets the border color for the application button.</summary>
    public abstract Color AppButtonBorder { get; set; }

    /// <summary>Gets or sets the first outer color for the application button.</summary>
    public abstract Color AppButtonOuter1 { get; set; }

    /// <summary>Gets or sets the second outer color for the application button.</summary>
    public abstract Color AppButtonOuter2 { get; set; }

    /// <summary>Gets or sets the third outer color for the application button.</summary>
    public abstract Color AppButtonOuter3 { get; set; }

    /// <summary>Gets or sets the first inner color for the application button.</summary>
    public abstract Color AppButtonInner1 { get; set; }

    /// <summary>Gets or sets the second inner color for the application button.</summary>
    public abstract Color AppButtonInner2 { get; set; }

    /// <summary>Gets or sets the background color for the application button's recent documents menu.</summary>
    public abstract Color AppButtonMenuDocsBack { get; set; }

    /// <summary>Gets or sets the text color for the application button's recent documents menu.</summary>
    public abstract Color AppButtonMenuDocsText { get; set; }
    /// <summary>Gets or sets the first internal border color for high-emphasis separators.</summary>
    public abstract Color SeparatorHighInternalBorder1 { get; set; }

    /// <summary>Gets or sets the second internal border color for high-emphasis separators.</summary>
    public abstract Color SeparatorHighInternalBorder2 { get; set; }

    /// <summary>Gets or sets the border color for the ribbon gallery.</summary>
    public abstract Color RibbonGalleryBorder { get; set; }

    /// <summary>Gets or sets the background color for the ribbon gallery in its normal state.</summary>
    public abstract Color RibbonGalleryBackNormal { get; set; }

    /// <summary>Gets or sets the background color for the ribbon gallery when tracking (hovered).</summary>
    public abstract Color RibbonGalleryBackTracking { get; set; }

    /// <summary>Gets or sets the first background color for the ribbon gallery.</summary>
    public abstract Color RibbonGalleryBack1 { get; set; }

    /// <summary>Gets or sets the second background color for the ribbon gallery.</summary>
    public abstract Color RibbonGalleryBack2 { get; set; }

    /// <summary>Gets or sets the third background color for ribbon tabs when tracking (hovered).</summary>
    public abstract Color RibbonTabTracking3 { get; set; }

    /// <summary>Gets or sets the fourth background color for ribbon tabs when tracking (hovered).</summary>
    public abstract Color RibbonTabTracking4 { get; set; }

    /// <summary>Gets or sets the third border color for ribbon groups.</summary>
    public abstract Color RibbonGroupBorder3 { get; set; }

    /// <summary>Gets or sets the fourth border color for ribbon groups.</summary>
    public abstract Color RibbonGroupBorder4 { get; set; }

    /// <summary>Gets or sets the fifth border color for ribbon groups.</summary>
    public abstract Color RibbonGroupBorder5 { get; set; }

    /// <summary>Gets or sets the text color for ribbon group titles.</summary>
    public abstract Color RibbonGroupTitleText { get; set; }

    /// <summary>Gets or sets the light color for ribbon drop arrows.</summary>
    public abstract Color RibbonDropArrowLight { get; set; }

    /// <summary>Gets or sets the dark color for ribbon drop arrows.</summary>
    public abstract Color RibbonDropArrowDark { get; set; }

    /// <summary>Gets or sets the first background color for inactive docked headers.</summary>
    public abstract Color HeaderDockInactiveBack1 { get; set; }

    /// <summary>Gets or sets the second background color for inactive docked headers.</summary>
    public abstract Color HeaderDockInactiveBack2 { get; set; }

    /// <summary>Gets or sets the border color for navigator buttons.</summary>
    public abstract Color ButtonNavigatorBorder { get; set; }

    /// <summary>Gets or sets the text color for navigator buttons.</summary>
    public abstract Color ButtonNavigatorText { get; set; }

    /// <summary>Gets or sets the first background color for navigator buttons when tracking (hovered).</summary>
    public abstract Color ButtonNavigatorTrack1 { get; set; }

    /// <summary>Gets or sets the second background color for navigator buttons when tracking (hovered).</summary>
    public abstract Color ButtonNavigatorTrack2 { get; set; }

    /// <summary>Gets or sets the first background color for navigator buttons when pressed.</summary>
    public abstract Color ButtonNavigatorPressed1 { get; set; }

    /// <summary>Gets or sets the second background color for navigator buttons when pressed.</summary>
    public abstract Color ButtonNavigatorPressed2 { get; set; }

    /// <summary>Gets or sets the first background color for navigator buttons when checked.</summary>
    public abstract Color ButtonNavigatorChecked1 { get; set; }

    /// <summary>Gets or sets the second background color for navigator buttons when checked.</summary>
    public abstract Color ButtonNavigatorChecked2 { get; set; }
    /// <summary>Gets or sets the background color for the bottom of tooltips.</summary>
    public abstract Color ToolTipBottom { get; set; }

    /// <summary>Gets or sets the text color for menu items.</summary>
    public abstract Color MenuItemText { get; set; }

    /// <summary>Gets or sets the starting color for the menu margin gradient.</summary>
    public abstract Color MenuMarginGradientStart { get; set; }

    /// <summary>Gets or sets the middle color for the menu margin gradient.</summary>
    public abstract Color MenuMarginGradientMiddle { get; set; }

    /// <summary>Gets or sets the ending color for the menu margin gradient.</summary>
    public abstract Color MenuMarginGradientEnd { get; set; }

    /// <summary>Gets or sets the text color for disabled menu items.</summary>
    public abstract Color DisabledMenuItemText { get; set; }

    /// <summary>Gets or sets the text color for the menu strip.</summary>
    public abstract Color MenuStripText { get; set; }

    /// <summary>Gets or sets the color for track bar tick marks.</summary>
    public abstract Color TrackBarTickMarks { get; set; }

    /// <summary>Gets or sets the color for the top track of the track bar.</summary>
    public abstract Color TrackBarTopTrack { get; set; }

    /// <summary>Gets or sets the color for the bottom track of the track bar.</summary>
    public abstract Color TrackBarBottomTrack { get; set; }

    /// <summary>Gets or sets the color for the filled portion of the track bar.</summary>
    public abstract Color TrackBarFillTrack { get; set; }

    /// <summary>Gets or sets the color for the outside position indicator of the track bar.</summary>
    public abstract Color TrackBarOutsidePosition { get; set; }

    /// <summary>Gets or sets the color for the border of the track bar position indicator.</summary>
    public abstract Color TrackBarBorderPosition { get; set; }

    #endregion
}
