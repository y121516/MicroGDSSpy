using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroGDSSpy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            axCadEvMgr60.Initialize = true;
        }

        static readonly ReadOnlyCollection<string> bTransparentMeans = Array.AsReadOnly(new string[]
        {
            "非透過",
            "透過",
        });
        string BTransparentToString(short bTransparent) => bTransparentMeans[bTransparent];

        string CommandIdToString(int commandId) => ((Informatix.MGDS.CMenu)commandId).ToString();

        enum CBPOS
        {
            CBPOS_KILL,  // コマンドがキャンセルされた
            CBPOS_DRAG,  // コマンドがドラッグを行っている
            CBPOS_HIT,   // スナップの結果
            CBPOS_BACK,  // 「BackSpace」キーが押された
            CBPOS_ENTER, // 「Enter」キーが押された
            CBPOS_TAB,   // 「Tab」キーが押された
        }
        string CCodeToString(int cCode) => ((CBPOS)cCode).ToString();

        static readonly ReadOnlyCollection<string> phaseStatusMeans = Array.AsReadOnly(new string[]
        {
            "編集可能",
            "参照可能",
            "表示",
            "非表示",
        });
        string PhaseStatusToString(int phaseStatus) => phaseStatusMeans[phaseStatus - 1];

        static readonly ReadOnlyCollection<string> layerOwnershipMeans = Array.AsReadOnly(new string[]
        {
            "非所有",
            "所有",
        });
        string LayerOwnershipToString(short layerOwnership) => layerOwnershipMeans[layerOwnership];

        static readonly ReadOnlyCollection<string> selectionModeMeans = Array.AsReadOnly(new string[]
        {
            "プリミティブ",
            "オブジェクト",
        });
        string SelectionModeToString(short mode) => selectionModeMeans[mode];

        static readonly ReadOnlyCollection<string> bNotMeans = Array.AsReadOnly(new string[]
        {
            "含む",
            "除く",
        });
        string BNotToString(short bNot) => bNotMeans[bNot];

        string PositionToString(double x, double y, double z)
            => string.Join("/", x, y, z);

        string LinkToString(int layer, int object_, int primitive)
            => string.Join("/", layer, object_, primitive);
        string LinkToString(int layer, int object_)
            => string.Join("/", layer, object_);

        char SnapCodeToString(short snapCode) => (char)snapCode;

        private void axMGDSListener_MicroGDSStart(object sender, AxCadevmgrLib60._DMGDSListenerEvents_MicroGDSStartEvent e)
        {
            var item = new ListViewItem(new string[]
            {
                "MicroGDSStart",
                "sessionID = " + e.sessionID
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CommandCallback(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CommandCallbackEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CommandCallback",
                string.Join("; ",
                    "bTransparent = " + BTransparentToString(e.bTransparent),
                    "commandId = " + CommandIdToString(e.commandId),
                    "cCode = " + CCodeToString(e.cCode),
                    "position = " + PositionToString(e.xP, e.yP, e.zP),
                    "link = " + LinkToString(e.layerLink, e.verLink, e.primLink),
                    "snapCode = " + SnapCodeToString(e.snapCode)
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CommandEnd(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CommandEndEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CommandEnd",
                string.Join("; ",
                    "bTransparent = " + BTransparentToString(e.bTransparent),
                    "commandId = " + CommandIdToString(e.commandId)
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CommandKeyCallback(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CommandKeyCallbackEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CommandKeyCallback",
                string.Join("; ",
                    "bTransparent = " + BTransparentToString(e.bTransparent),
                    "commandId = " + CommandIdToString(e.commandId),
                    "cCode = " + CCodeToString(e.cCode),
                    "position = " + PositionToString(e.xP, e.yP, e.zP),
                    "link = " + LinkToString(e.layerLink, e.verLink, e.primLink),
                    "snapCode = " + SnapCodeToString(e.snapCode)
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CommandStart(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CommandStartEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CommandStart",
                string.Join("; ",
                    "bTransparent = " + BTransparentToString(e.bTransparent),
                    "commandId = " + CommandIdToString(e.commandId)
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurDocChange(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurDocChangeEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurDocChange",
                "Document = " + e.document
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurDocClose(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurDocCloseEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurDocClose",
                "Document = " + e.document
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurPhase(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurPhase",
                string.Join("; ",
                    "PhaseNum = " + e.phaseNum,
                    "PhaseLink = " + e.phaseLink,
                    "nReserved = " + e.nReserved
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurPhaseCharStyle(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseCharStyleEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurPhaseCharStyle",
                string.Join("; ",
                    "PhaseNum = " + e.phaseNum,
                    "PhaseLink = " + e.phaseLink,
                    "CharStyle = " + e.charStyle
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurPhaseColour(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseColourEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurPhaseColour",
                string.Join("; ",
                    "PhaseNum = " + e.phaseNum,
                    "PhaseLink = " + e.phaseLink,
                    "Colour = " + e.colour
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurPhaseInclusion(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseInclusionEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurPhaseInclusion",
                string.Join("; ",
                    "PhaseNum = " + e.phaseNum,
                    "PhaseLink = " + e.phaseLink,
                    "Inclusion = " + e.inclusion
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurPhaseLineStyle(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseLineStyleEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurPhaseLineStyle",
                string.Join("; ",
                    "PhaseNum = " + e.phaseNum,
                    "PhaseLink = " + e.phaseLink,
                    "LineStyle = " + e.lineStyle
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurPhaseLink(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseLinkEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurPhaseLink",
                string.Join("; ",
                    "PhaseNum = " + e.phaseNum,
                    "PhaseLink = " + e.phaseLink,
                    "PhaseStatus = " + e.phaseStatus
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurPhaseMaterial(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseMaterialEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurPhaseMaterial",
                string.Join("; ",
                    "PhaseNum = " + e.phaseNum,
                    "PhaseLink = " + e.phaseLink,
                    "Material = " + e.material
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurPhasePen(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurPhasePenEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurPhasePen",
                string.Join("; ",
                    "PhaseNum = " + e.phaseNum,
                    "PhaseLink = " + e.phaseLink,
                    "Pen = " + e.pen
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurPhaseStatus(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurPhaseStatusEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurPhaseStatus",
                string.Join("; ",
                    "PhaseNum = " + e.phaseNum,
                    "PhaseLink = " + e.phaseLink,
                    "Status = " + PhaseStatusToString(e.status)
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurViewChange(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurViewChangeEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurViewChange",
                "View = " + e.view
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurViewClose(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurViewCloseEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurViewClose",
                "View = " + e.view
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurViewExtents(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurViewExtentsEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurViewExtents",
                string.Join("; ",
                    "vwLeft = " + e.vwLeft,
                    "vwTop = " + e.vwTop,
                    "vwRight = " + e.vwRight,
                    "vwBottom = " + e.vwBottom
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CurViewSave(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CurViewSaveEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CurViewSave",
                "View = " + e.view
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CustomCommand(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CustomCommandEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CustomCommand",
                string.Join("; ",
                    "eventID = " + e.eventID,
                    "userData = " + e.userData,
                    "isChecked = " + e.isChecked
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CustomControl(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CustomControlEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CustomControl",
                string.Join("; ",
                    "text = " + e.text,
                    "listIndex = " + e.listIndex,
                    "eventID = " + e.eventID,
                    "userData = " + e.userData
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CustomMenu(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CustomMenuEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CustomMenu",
                "MenuID = " + e.menuID
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_CustomMenuPopup(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_CustomMenuPopupEvent e)
        {
            var item = new ListViewItem(new string[]{
                "CustomMenuPopup",
                string.Join("; ",
                    "bTransparent = " + BTransparentToString(e.bTransparent),
                    "eventID = " + e.eventID,
                    "cCode = " + e.cCode,
                    "Position = " + PositionToString(e.xP,e.yP,e.zP),
                    "Link = " + LinkToString(e.layerLink,e.verLink,e.primLink),
                    "snapCode = " + e.snapCode
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_DynamicPos(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_DynamicPosEvent e)
        {
            var item = new ListViewItem(new string[]{
                "DynamicPos",
                string.Join("; ",
                    "Position = " + PositionToString(e.x,e.y,e.z),
                    "SnapCode = " + SnapCodeToString(e.snapCode)
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_EditDelete(object sender, EventArgs e)
        {
            var item = new ListViewItem(new string[]{
                "EditDelete",
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_EditPlaceItem(object sender, EventArgs e)
        {
            var item = new ListViewItem(new string[]{
                "EditPlaceItem",
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_LayerName(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_LayerNameEvent e)
        {
            var item = new ListViewItem(new string[]{
                "LayerName",
                string.Join("; ",
                    "LayerLink = " + e.layerLink,
                    "LayerName = " + e.layerName
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_LayerOwnership(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_LayerOwnershipEvent e)
        {
            var item = new ListViewItem(new string[]{
                "LayerOwnership",
                string.Join("; ",
                    "LayerLink = " + e.layerLink,
                    "Status = " + LayerOwnershipToString(e.status)
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_LayerUpdate(object sender, EventArgs e)
        {
            var item = new ListViewItem(new string[]{
                "LayerUpdate",
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_MgdsActivate(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_MgdsActivateEvent e)
        {
            var item = new ListViewItem(new string[]{
                "MgdsActivate",
                "Active = " + Convert.ToBoolean(e.active)
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_MgdsClose(object sender, EventArgs e)
        {
            axCadEvMgr60.SessionID = 0;
            var item = new ListViewItem(new string[]{
                "MgdsClose",
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_MgdsPosition(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_MgdsPositionEvent e)
        {
            var item = new ListViewItem(new string[]{
                "MgdsPosition",
                string.Join("; ",
                    "frmLeft = " + e.frmLeft,
                    "frmTop = " + e.frmTop,
                    "frmRight = " + e.frmRight,
                    "frmBottom = " + e.frmBottom,
                    "cliLeft = " + e.cliLeft,
                    "cliTop = " + e.cliTop,
                    "cliRight = " + e.cliRight,
                    "cliBottom = " + e.cliBottom
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_PrintEnd(object sender, EventArgs e)
        {
            var item = new ListViewItem(new string[]{
                "PrintEnd",
            });
            eventListView.Items.Insert(0, item);

        }

        private void axCadEvMgr60_PrintStart(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_PrintStartEvent e)
        {
            var item = new ListViewItem(new string[]{
                "PrintStart",
                string.Join("; ",
                    "Filename = " + e.filename,
                    "Printer = " + e.printer
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_SelectionList(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_SelectionListEvent e)
        {
            var item = new ListViewItem(new string[]{
                "SelectionList",
                "ItemCount = " + e.itemCount
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_SelectionMode(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_SelectionModeEvent e)
        {
            var item = new ListViewItem(new string[]{
                "SelectionMode",
                "Mode = " + SelectionModeToString(e.mode)
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_SetAxes(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_SetAxesEvent e)
        {
            var item = new ListViewItem(new string[]{
                "SetAxes",
                string.Join("; ",
                    PositionToString(e.xO,e.yO,e.zO),
                    "xR = " + e.xR,
                    "yR = " + e.yR,
                    "zR = " + e.zR,
                    "CadScale = " + e.cadScale
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_SetCharStyle(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_SetCharStyleEvent e)
        {
            var item = new ListViewItem(new string[]{
                "SetCharStyle",
                "CharStyle = " + e.charStyle
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_SetEditCharStyle(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_SetEditCharStyleEvent e)
        {
            var item = new ListViewItem(new string[]{
                "SetEditCharStyle",
                string.Join("; ",
                    "bNot = " + BNotToString(e.bNot),
                    "CharStyle = " + e.charStyle
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_SetEditColour(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_SetEditColourEvent e)
        {
            var item = new ListViewItem(new string[]{
                "SetEditColour",
                string.Join("; ",
                    "bNot = " + BNotToString(e.bNot),
                    "Colour = " + e.colour
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_SetEditLineStyle(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_SetEditLineStyleEvent e)
        {
            var item = new ListViewItem(new string[]{
                "SetEditLineStyle",
                string.Join("; ",
                    "bNot = " + BNotToString(e.bNot),
                    "LineStyle = " + e.lineStyle
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_SetEditMaterial(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_SetEditMaterialEvent e)
        {
            var item = new ListViewItem(new string[]{
                "SetEditMaterial",
                string.Join("; ",
                    "bNot = " + BNotToString(e.bNot),
                    "Material = " + e.material
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_SetEditObject(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_SetEditObjectEvent e)
        {
            var item = new ListViewItem(new string[]{
                "SetEditObject",
                "ObjectFilter = " + e.objectFilter
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_SetLayer(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_SetLayerEvent e)
        {
            var item = new ListViewItem(new string[]{
                "SetLayer",
                "LayerLink = " + e.layerLink
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_SetLineStyle(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_SetLineStyleEvent e)
        {
            var item = new ListViewItem(new string[]{
                "SetLineStyle",
                "LineStyle = " + e.lineStyle
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_SetObject(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_SetObjectEvent e)
        {
            var item = new ListViewItem(new string[]{
                "SetObject",
                LinkToString(e.layerLink, e.verLink)
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_SetUnits(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_SetUnitsEvent e)
        {
            var item = new ListViewItem(new string[]{
                "SetUnits",
                string.Join("; ",
                    "Units = " + e.units,
                    "Precision = " + e.precision
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void axCadEvMgr60_Snap(object sender, AxCadevmgrLib60._DCadEvMgrEvents60_SnapEvent e)
        {
            var item = new ListViewItem(new string[]{
                "Snap",
                string.Join("; ",
                    PositionToString(e.x,e.y,e.z),
                    "SnapCode = " + SnapCodeToString(e.snapCode),
                    "Link = " + LinkToString(e.layerLink, e.verLink, e.primLink)
                )
            });
            eventListView.Items.Insert(0, item);
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axCadEvMgr60.ShowPropertyPages();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axCadEvMgr60.ShowAboutBox();
        }
    }
}
