#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner (aka Wagnerp), Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, tobitege et al. 2025 - 2025. All rights reserved.
 *
 */
#endregion

namespace Krypton.Toolkit;

/// <summary>
/// Represents an empty color scheme implementation where all color values are set to a default empty color.
/// </summary>
/// <remarks>
/// This class provides a base implementation that can be used as a starting point for creating new color schemes
/// or as a fallback when no specific colors are desired. All color properties return the value defined in
/// <see cref="GlobalStaticValues.EMPTY_COLOR"/>.
/// </remarks>
public sealed class EmptySchemeBase : KryptonColorSchemeBase
{
    /// <inheritdoc />
    public override Color TextLabelControl                 { get; set; } = GlobalStaticValues.EMPTY_COLOR;

    /// <inheritdoc />
    public override Color TextButtonNormal                 { get; set; } = GlobalStaticValues.EMPTY_COLOR;

    /// <inheritdoc />
    public override Color TextButtonChecked                { get; set; } = GlobalStaticValues.EMPTY_COLOR;

    /// <inheritdoc />
    public override Color ButtonNormalBorder               { get; set; } = GlobalStaticValues.EMPTY_COLOR;

    /// <inheritdoc />
    public override Color ButtonNormalDefaultBorder        { get; set; } = GlobalStaticValues.EMPTY_COLOR;

    /// <inheritdoc />
    public override Color ButtonNormalBack1                { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonNormalBack2                { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonNormalDefaultBack1         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonNormalDefaultBack2         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonNormalNavigatorBack1       { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonNormalNavigatorBack2       { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color PanelClient                      { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color PanelAlternative                 { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ControlBorder                    { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color SeparatorHighBorder1             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color SeparatorHighBorder2             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color HeaderPrimaryBack1               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color HeaderPrimaryBack2               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color HeaderSecondaryBack1             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color HeaderSecondaryBack2             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color HeaderText                       { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color StatusStripText                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonBorder                     { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color SeparatorLight                   { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color SeparatorDark                    { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GripLight                        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GripDark                         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ToolStripBack                    { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color StatusStripLight                 { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color StatusStripDark                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ImageMargin                      { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ToolStripBegin                   { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ToolStripMiddle                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ToolStripEnd                     { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color OverflowBegin                    { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color OverflowMiddle                   { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color OverflowEnd                      { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ToolStripBorder                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormBorderActive                 { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormBorderInactive               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormBorderActiveLight            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormBorderActiveDark             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormBorderInactiveLight          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormBorderInactiveDark           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormBorderHeaderActive           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormBorderHeaderInactive         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormBorderHeaderActive1          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormBorderHeaderActive2          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormBorderHeaderInactive1        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormBorderHeaderInactive2        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormHeaderShortActive            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormHeaderShortInactive          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormHeaderLongActive             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormHeaderLongInactive           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormButtonBorderTrack            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormButtonBack1Track             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormButtonBack2Track             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormButtonBorderPressed          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormButtonBack1Pressed           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormButtonBack2Pressed           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color TextButtonFormNormal             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color TextButtonFormTracking           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color TextButtonFormPressed            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color LinkNotVisitedOverrideControl    { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color LinkVisitedOverrideControl       { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color LinkPressedOverrideControl       { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color LinkNotVisitedOverridePanel      { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color LinkVisitedOverridePanel         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color LinkPressedOverridePanel         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color TextLabelPanel                   { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabTextNormal              { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabTextChecked             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabSelected1               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabSelected2               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabSelected3               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabSelected4               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabSelected5               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabTracking1               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabTracking2               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabHighlight1              { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabHighlight2              { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabHighlight3              { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabHighlight4              { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabHighlight5              { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabSeparatorColor          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupsArea1                { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupsArea2                { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupsArea3                { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupsArea4                { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupsArea5                { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupBorder1               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupBorder2               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupTitle1                { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupTitle2                { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupBorderContext1        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupBorderContext2        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupTitleContext1         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupTitleContext2         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupDialogDark            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupDialogLight           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupTitleTracking1        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupTitleTracking2        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonMinimizeBarDark            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonMinimizeBarLight           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBorder1      { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBorder2      { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBorder3      { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBorder4      { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBack1        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBack2        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBack3        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBack4        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBorderT1     { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBorderT2     { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBorderT3     { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBorderT4     { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBackT1       { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBackT2       { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBackT3       { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedBackT4       { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupFrameBorder1          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupFrameBorder2          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupFrameInside1          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupFrameInside2          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupFrameInside3          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupFrameInside4          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupCollapsedText         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupButtonText            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color AlternatePressedBack1            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color AlternatePressedBack2            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color AlternatePressedBorder1          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color AlternatePressedBorder2          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormButtonBack1Checked           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormButtonBack2Checked           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormButtonBorderCheck            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormButtonBack1CheckTrack        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color FormButtonBack2CheckTrack        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATMini1                   { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATMini2                   { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATMini3                   { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATMini4                   { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATMini5                   { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATMini1I                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATMini2I                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATMini3I                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATMini4I                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATMini5I                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATFullbar1                { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATFullbar2                { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATFullbar3                { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATButtonDark              { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATButtonLight             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATOverflow1               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonQATOverflow2               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupSeparatorDark         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupSeparatorLight        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonClusterButtonBack1         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonClusterButtonBack2         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonClusterButtonBorder1       { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonClusterButtonBorder2       { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color NavigatorMiniBackColor           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridListNormal1                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridListNormal2                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridListPressed1                 { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridListPressed2                 { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridListSelected                 { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridSheetColNormal1              { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridSheetColNormal2              { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridSheetColPressed1             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridSheetColPressed2             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridSheetColSelected1            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridSheetColSelected2            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridSheetRowNormal               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridSheetRowPressed              { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridSheetRowSelected             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridDataCellBorder               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color GridDataCellSelected             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color InputControlTextNormal           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color InputControlTextDisabled         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color InputControlBorderNormal         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color InputControlBorderDisabled       { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color InputControlBackNormal           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color InputControlBackDisabled         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color InputControlBackInactive         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color InputDropDownNormal1             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color InputDropDownNormal2             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color InputDropDownDisabled1           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color InputDropDownDisabled2           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ContextMenuHeadingBack           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ContextMenuHeadingText           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ContextMenuImageColumn           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color AppButtonBack1                   { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color AppButtonBack2                   { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color AppButtonBorder                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color AppButtonOuter1                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color AppButtonOuter2                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color AppButtonOuter3                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color AppButtonInner1                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color AppButtonInner2                  { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color AppButtonMenuDocsBack            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color AppButtonMenuDocsText            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color SeparatorHighInternalBorder1     { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color SeparatorHighInternalBorder2     { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGalleryBorder              { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGalleryBackNormal          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGalleryBackTracking        { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGalleryBack1               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGalleryBack2               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabTracking3               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonTabTracking4               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupBorder3               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupBorder4               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupBorder5               { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonGroupTitleText             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonDropArrowLight             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color RibbonDropArrowDark              { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color HeaderDockInactiveBack1          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color HeaderDockInactiveBack2          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonNavigatorBorder            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonNavigatorText              { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonNavigatorTrack1            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonNavigatorTrack2            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonNavigatorPressed1          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonNavigatorPressed2          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonNavigatorChecked1          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ButtonNavigatorChecked2          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color ToolTipBottom                    { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color MenuItemText                     { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color MenuMarginGradientStart          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color MenuMarginGradientMiddle         { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color MenuMarginGradientEnd            { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color DisabledMenuItemText             { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color MenuStripText                    { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color TrackBarTickMarks                { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color TrackBarTopTrack                 { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color TrackBarBottomTrack              { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color TrackBarFillTrack                { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color TrackBarOutsidePosition          { get; set; } = GlobalStaticValues.EMPTY_COLOR;
    /// <inheritdoc />
    public override Color TrackBarBorderPosition           { get; set; } = GlobalStaticValues.EMPTY_COLOR;
}
