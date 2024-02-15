using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Different
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class InspireResource
    {

        private InspireResourceVersionInfo versionInfoField;

        private InspireResourceProjectInfo projectInfoField;

        private InspireResourceTerrainInfo terrainInfoField;

        private InspireResourceResource[] resourceInfoField;

        private InspireResourceTrigger[] triggerInfoField;

        /// <remarks/>
        public InspireResourceVersionInfo VersionInfo
        {
            get
            {
                return this.versionInfoField;
            }
            set
            {
                this.versionInfoField = value;
            }
        }

        /// <remarks/>
        public InspireResourceProjectInfo ProjectInfo
        {
            get
            {
                return this.projectInfoField;
            }
            set
            {
                this.projectInfoField = value;
            }
        }

        /// <remarks/>
        public InspireResourceTerrainInfo TerrainInfo
        {
            get
            {
                return this.terrainInfoField;
            }
            set
            {
                this.terrainInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Resource", IsNullable = false)]
        public InspireResourceResource[] ResourceInfo
        {
            get
            {
                return this.resourceInfoField;
            }
            set
            {
                this.resourceInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Trigger", IsNullable = false)]
        public InspireResourceTrigger[] TriggerInfo
        {
            get
            {
                return this.triggerInfoField;
            }
            set
            {
                this.triggerInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InspireResourceVersionInfo
    {

        private string fileVersionField;

        /// <remarks/>
        public string FileVersion
        {
            get
            {
                return this.fileVersionField;
            }
            set
            {
                this.fileVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InspireResourceProjectInfo
    {

        private decimal startFrameField;

        private ushort endFrameField;

        private string isFixFrameField;

        /// <remarks/>
        public decimal StartFrame
        {
            get
            {
                return this.startFrameField;
            }
            set
            {
                this.startFrameField = value;
            }
        }

        /// <remarks/>
        public ushort EndFrame
        {
            get
            {
                return this.endFrameField;
            }
            set
            {
                this.endFrameField = value;
            }
        }

        /// <remarks/>
        public string IsFixFrame
        {
            get
            {
                return this.isFixFrameField;
            }
            set
            {
                this.isFixFrameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InspireResourceTerrainInfo
    {

        private object terrainGroupField;

        private string matrixField;

        /// <remarks/>
        public object TerrainGroup
        {
            get
            {
                return this.terrainGroupField;
            }
            set
            {
                this.terrainGroupField = value;
            }
        }

        /// <remarks/>
        public string Matrix
        {
            get
            {
                return this.matrixField;
            }
            set
            {
                this.matrixField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InspireResourceResource
    {

        private decimal idField;

        private string typeField;

        private InspireResourceResourceParam paramField;

        /// <remarks/>
        public decimal ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public InspireResourceResourceParam Param
        {
            get
            {
                return this.paramField;
            }
            set
            {
                this.paramField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InspireResourceResourceParam
    {

        private string fileNameField;

        private decimal modelIDField;

        private bool modelIDFieldSpecified;

        private string materialNameField;

        private string assignResourceTypeField;

        private decimal assignResourceIDField;

        private bool assignResourceIDFieldSpecified;

        private string nodeNameField;

        private string isFollowNodeField;

        private string isInheritPositionOnlyField;

        private InspireResourceResourceParamTranslation translationField;

        private InspireResourceResourceParamRotation rotationField;

        private decimal scaleField;

        private bool scaleFieldSpecified;

        private string skeltonDataField;

        private string indexNameField;

        private string isManualClipField;

        private decimal nearPlaneField;

        private bool nearPlaneFieldSpecified;

        private decimal farPlaneField;

        private bool farPlaneFieldSpecified;

        private decimal shadowMapBoxWidthField;

        private bool shadowMapBoxWidthFieldSpecified;

        private decimal shadowMapBoxHeightField;

        private bool shadowMapBoxHeightFieldSpecified;

        private decimal shadowMapBoxNearField;

        private bool shadowMapBoxNearFieldSpecified;

        private decimal shadowMapBoxFarField;

        private bool shadowMapBoxFarFieldSpecified;

        private decimal shadowMapBoxNRateField;

        private bool shadowMapBoxNRateFieldSpecified;

        private string isUseUserParamField;

        private string isNoUseField;

        private InspireResourceResourceParamCPostEffectInfo cPostEffectInfoField;

        /// <remarks/>
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        public decimal ModelID
        {
            get
            {
                return this.modelIDField;
            }
            set
            {
                this.modelIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModelIDSpecified
        {
            get
            {
                return this.modelIDFieldSpecified;
            }
            set
            {
                this.modelIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string MaterialName
        {
            get
            {
                return this.materialNameField;
            }
            set
            {
                this.materialNameField = value;
            }
        }

        /// <remarks/>
        public string AssignResourceType
        {
            get
            {
                return this.assignResourceTypeField;
            }
            set
            {
                this.assignResourceTypeField = value;
            }
        }

        /// <remarks/>
        public decimal AssignResourceID
        {
            get
            {
                return this.assignResourceIDField;
            }
            set
            {
                this.assignResourceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AssignResourceIDSpecified
        {
            get
            {
                return this.assignResourceIDFieldSpecified;
            }
            set
            {
                this.assignResourceIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string NodeName
        {
            get
            {
                return this.nodeNameField;
            }
            set
            {
                this.nodeNameField = value;
            }
        }

        /// <remarks/>
        public string IsFollowNode
        {
            get
            {
                return this.isFollowNodeField;
            }
            set
            {
                this.isFollowNodeField = value;
            }
        }

        /// <remarks/>
        public string IsInheritPositionOnly
        {
            get
            {
                return this.isInheritPositionOnlyField;
            }
            set
            {
                this.isInheritPositionOnlyField = value;
            }
        }

        /// <remarks/>
        public InspireResourceResourceParamTranslation Translation
        {
            get
            {
                return this.translationField;
            }
            set
            {
                this.translationField = value;
            }
        }

        /// <remarks/>
        public InspireResourceResourceParamRotation Rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
        
    [XmlIgnore]
        public string Scale
        {
            get { return this.scaleField.ToString(); }
            set { this.scaleField = Convert.ToDecimal(value); }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScaleSpecified
        {
            get
            {
                return this.scaleFieldSpecified;
            }
            set
            {
                this.scaleFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string SkeltonData
        {
            get
            {
                return this.skeltonDataField;
            }
            set
            {
                this.skeltonDataField = value;
            }
        }

        [XmlIgnore]
        /// <remarks/>
        public string IndexName
        {
            get
            {
                return this.indexNameField;
            }
            set
            {
                this.indexNameField = value;
            }
        }

        [XmlIgnore]
        /// <remarks/>
        public string IsManualClip
        {
            get
            {
                return this.isManualClipField;
            }
            set
            {
                this.isManualClipField = value;
            }
        }

        public string NearPlane
        {
            get { return this.nearPlaneField.ToString(); }
            set { this.nearPlaneField = Convert.ToDecimal(value); }
        }       
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NearPlaneSpecified
        {
            get
            {
                return this.nearPlaneFieldSpecified;
            }
            set
            {
                this.nearPlaneFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal FarPlane
        {
            get
            {
                return this.farPlaneField;
            }
            set
            {
                this.farPlaneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FarPlaneSpecified
        {
            get
            {
                return this.farPlaneFieldSpecified;
            }
            set
            {
                this.farPlaneFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal ShadowMapBoxWidth
        {
            get
            {
                return this.shadowMapBoxWidthField;
            }
            set
            {
                this.shadowMapBoxWidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShadowMapBoxWidthSpecified
        {
            get
            {
                return this.shadowMapBoxWidthFieldSpecified;
            }
            set
            {
                this.shadowMapBoxWidthFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal ShadowMapBoxHeight
        {
            get
            {
                return this.shadowMapBoxHeightField;
            }
            set
            {
                this.shadowMapBoxHeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShadowMapBoxHeightSpecified
        {
            get
            {
                return this.shadowMapBoxHeightFieldSpecified;
            }
            set
            {
                this.shadowMapBoxHeightFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal ShadowMapBoxNear
        {
            get
            {
                return this.shadowMapBoxNearField;
            }
            set
            {
                this.shadowMapBoxNearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShadowMapBoxNearSpecified
        {
            get
            {
                return this.shadowMapBoxNearFieldSpecified;
            }
            set
            {
                this.shadowMapBoxNearFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal ShadowMapBoxFar
        {
            get
            {
                return this.shadowMapBoxFarField;
            }
            set
            {
                this.shadowMapBoxFarField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShadowMapBoxFarSpecified
        {
            get
            {
                return this.shadowMapBoxFarFieldSpecified;
            }
            set
            {
                this.shadowMapBoxFarFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal ShadowMapBoxNRate
        {
            get
            {
                return this.shadowMapBoxNRateField;
            }
            set
            {
                this.shadowMapBoxNRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShadowMapBoxNRateSpecified
        {
            get
            {
                return this.shadowMapBoxNRateFieldSpecified;
            }
            set
            {
                this.shadowMapBoxNRateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string IsUseUserParam
        {
            get
            {
                return this.isUseUserParamField;
            }
            set
            {
                this.isUseUserParamField = value;
            }
        }

        /// <remarks/>
        public string IsNoUse
        {
            get
            {
                return this.isNoUseField;
            }
            set
            {
                this.isNoUseField = value;
            }
        }

        /// <remarks/>
        public InspireResourceResourceParamCPostEffectInfo CPostEffectInfo
        {
            get
            {
                return this.cPostEffectInfoField;
            }
            set
            {
                this.cPostEffectInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InspireResourceResourceParamTranslation
    {

        private decimal xField;

        private decimal yField;

        private decimal zField;

        /// <remarks/>
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public decimal z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InspireResourceResourceParamRotation
    {

        private decimal xField;

        private decimal yField;

        private decimal zField;

        private decimal wField;

        /// <remarks/>
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public decimal z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }

        /// <remarks/>
        public decimal w
        {
            get
            {
                return this.wField;
            }
            set
            {
                this.wField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InspireResourceResourceParamCPostEffectInfo
    {

        private string kindField;

        private InspireResourceResourceParamCPostEffectInfoFunctionCurve[] functionCurveField;

        /// <remarks/>
        public string Kind
        {
            get
            {
                return this.kindField;
            }
            set
            {
                this.kindField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FunctionCurve")]
        public InspireResourceResourceParamCPostEffectInfoFunctionCurve[] FunctionCurve
        {
            get
            {
                return this.functionCurveField;
            }
            set
            {
                this.functionCurveField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InspireResourceResourceParamCPostEffectInfoFunctionCurve
    {

        private string nameField;

        private string curveTypeField;

        private InspireResourceResourceParamCPostEffectInfoFunctionCurveKeyFrame[] keyFramListField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string CurveType
        {
            get
            {
                return this.curveTypeField;
            }
            set
            {
                this.curveTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyFrame", IsNullable = false)]
        public InspireResourceResourceParamCPostEffectInfoFunctionCurveKeyFrame[] KeyFramList
        {
            get
            {
                return this.keyFramListField;
            }
            set
            {
                this.keyFramListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InspireResourceResourceParamCPostEffectInfoFunctionCurveKeyFrame
    {

        private decimal timeField;

        private decimal valueField;

        private decimal valueUpperBiasField;

        private decimal valueLowerBiasField;

        private decimal slopeLField;

        private decimal slopeRField;

        private decimal slopeLUpperBiasField;

        private decimal slopeLLowerBiasField;

        private decimal slopeRUpperBiasField;

        private decimal slopeRLowerBiasField;

        private bool keyBreakField;

        /// <remarks/>
        public decimal Time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        public decimal ValueUpperBias
        {
            get
            {
                return this.valueUpperBiasField;
            }
            set
            {
                this.valueUpperBiasField = value;
            }
        }

        /// <remarks/>
        public decimal ValueLowerBias
        {
            get
            {
                return this.valueLowerBiasField;
            }
            set
            {
                this.valueLowerBiasField = value;
            }
        }

        /// <remarks/>
        public decimal SlopeL
        {
            get
            {
                return this.slopeLField;
            }
            set
            {
                this.slopeLField = value;
            }
        }

        /// <remarks/>
        public decimal SlopeR
        {
            get
            {
                return this.slopeRField;
            }
            set
            {
                this.slopeRField = value;
            }
        }

        /// <remarks/>
        public decimal SlopeLUpperBias
        {
            get
            {
                return this.slopeLUpperBiasField;
            }
            set
            {
                this.slopeLUpperBiasField = value;
            }
        }

        /// <remarks/>
        public decimal SlopeLLowerBias
        {
            get
            {
                return this.slopeLLowerBiasField;
            }
            set
            {
                this.slopeLLowerBiasField = value;
            }
        }

        /// <remarks/>
        public decimal SlopeRUpperBias
        {
            get
            {
                return this.slopeRUpperBiasField;
            }
            set
            {
                this.slopeRUpperBiasField = value;
            }
        }

        /// <remarks/>
        public decimal SlopeRLowerBias
        {
            get
            {
                return this.slopeRLowerBiasField;
            }
            set
            {
                this.slopeRLowerBiasField = value;
            }
        }

        /// <remarks/>
        public bool KeyBreak
        {
            get
            {
                return this.keyBreakField;
            }
            set
            {
                this.keyBreakField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InspireResourceTrigger
    {

        private decimal resourceIDField;

        private InspireResourceTriggerFrame frameField;

        /// <remarks/>
        public decimal ResourceID
        {
            get
            {
                return this.resourceIDField;
            }
            set
            {
                this.resourceIDField = value;
            }
        }

        /// <remarks/>
        public InspireResourceTriggerFrame Frame
        {
            get
            {
                return this.frameField;
            }
            set
            {
                this.frameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InspireResourceTriggerFrame
    {

        private string typeField;

        private ushort startField;

        private ushort endField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public ushort Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        public ushort End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
    }


}
