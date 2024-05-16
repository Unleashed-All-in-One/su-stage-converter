using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC_Converter
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class InportExportEffect
    {

        private InportExportEffectExportInfo exportInfoField;

        private InportExportEffectEffectSaveLoad effectSaveLoadField;

        /// <remarks/>
        public InportExportEffectExportInfo ExportInfo
        {
            get
            {
                return this.exportInfoField;
            }
            set
            {
                this.exportInfoField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoad EffectSaveLoad
        {
            get
            {
                return this.effectSaveLoadField;
            }
            set
            {
                this.effectSaveLoadField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectExportInfo
    {

        private string exportDateField;

        private string versionField;

        private string authorField;

        /// <remarks/>
        public string ExportDate
        {
            get
            {
                return this.exportDateField;
            }
            set
            {
                this.exportDateField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoad
    {

        private string exportDateField;

        private string versionField;

        private string authorField;

        private InportExportEffectEffectSaveLoadExportInfo exportInfoField;

        private string effectNameField;

        private float initialLifeTimeField;

        private float scaleRatioField;

        private float generateCountRatioField;

        private InportExportEffectEffectSaveLoadInitialPosition initialPositionField;

        private InportExportEffectEffectSaveLoadInitialRotation initialRotationField;

        private bool isLoopField;

        private bool deleteChildrenField;

        private float velocityOffsetField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoad[] emitterSaveLoadListField;

        /// <remarks/>
        public string ExportDate
        {
            get
            {
                return this.exportDateField;
            }
            set
            {
                this.exportDateField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadExportInfo ExportInfo
        {
            get
            {
                return this.exportInfoField;
            }
            set
            {
                this.exportInfoField = value;
            }
        }

        /// <remarks/>
        public string EffectName
        {
            get
            {
                return this.effectNameField;
            }
            set
            {
                this.effectNameField = value;
            }
        }

        /// <remarks/>
        public float InitialLifeTime
        {
            get
            {
                return this.initialLifeTimeField;
            }
            set
            {
                this.initialLifeTimeField = value;
            }
        }

        /// <remarks/>
        public float ScaleRatio
        {
            get
            {
                return this.scaleRatioField;
            }
            set
            {
                this.scaleRatioField = value;
            }
        }

        /// <remarks/>
        public float GenerateCountRatio
        {
            get
            {
                return this.generateCountRatioField;
            }
            set
            {
                this.generateCountRatioField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadInitialPosition InitialPosition
        {
            get
            {
                return this.initialPositionField;
            }
            set
            {
                this.initialPositionField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadInitialRotation InitialRotation
        {
            get
            {
                return this.initialRotationField;
            }
            set
            {
                this.initialRotationField = value;
            }
        }

        /// <remarks/>
        public bool IsLoop
        {
            get
            {
                return this.isLoopField;
            }
            set
            {
                this.isLoopField = value;
            }
        }

        /// <remarks/>
        public bool DeleteChildren
        {
            get
            {
                return this.deleteChildrenField;
            }
            set
            {
                this.deleteChildrenField = value;
            }
        }

        /// <remarks/>
        public float VelocityOffset
        {
            get
            {
                return this.velocityOffsetField;
            }
            set
            {
                this.velocityOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EmitterSaveLoad", IsNullable = false)]
        public InportExportEffectEffectSaveLoadEmitterSaveLoad[] EmitterSaveLoadList
        {
            get
            {
                return this.emitterSaveLoadListField;
            }
            set
            {
                this.emitterSaveLoadListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadExportInfo
    {

        private string exportDateField;

        private string versionField;

        private string authorField;

        /// <remarks/>
        public string ExportDate
        {
            get
            {
                return this.exportDateField;
            }
            set
            {
                this.exportDateField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadInitialPosition
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadInitialRotation
    {

        private float xField;

        private float yField;

        private float zField;

        private float wField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
        public float W
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoad
    {

        private InportExportEffectEffectSaveLoadEmitterSaveLoadExportInfo exportInfoField;

        private string emitterNameField;

        private float maxGenerateCountField;

        private float generateCountField;

        private ushort particleDataFlagsField;

        private bool infiniteField;

        private float initialEmittionGapField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadInitialPosition initialPositionField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadRotationXYZ rotationXYZField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadRotationXYZBias rotationXYZBiasField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadInitialRotationXYZ initialRotationXYZField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadInitialRotation initialRotationField;

        private float initialEmitterLifeTimeField;

        private float emitStartTimeField;

        private string emitConditionField;

        private string emitterTypeField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadCylinderParams cylinderParamsField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadSphereParams sphereParamsField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadBoxParams boxParamsField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadMeshParams meshParamsField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadList particleSaveLoadListField;

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadExportInfo ExportInfo
        {
            get
            {
                return this.exportInfoField;
            }
            set
            {
                this.exportInfoField = value;
            }
        }

        /// <remarks/>
        public string EmitterName
        {
            get
            {
                return this.emitterNameField;
            }
            set
            {
                this.emitterNameField = value;
            }
        }

        /// <remarks/>
        public float MaxGenerateCount
        {
            get
            {
                return this.maxGenerateCountField;
            }
            set
            {
                this.maxGenerateCountField = value;
            }
        }

        /// <remarks/>
        public float GenerateCount
        {
            get
            {
                return this.generateCountField;
            }
            set
            {
                this.generateCountField = value;
            }
        }

        /// <remarks/>
        public ushort ParticleDataFlags
        {
            get
            {
                return this.particleDataFlagsField;
            }
            set
            {
                this.particleDataFlagsField = value;
            }
        }

        /// <remarks/>
        public bool Infinite
        {
            get
            {
                return this.infiniteField;
            }
            set
            {
                this.infiniteField = value;
            }
        }

        /// <remarks/>
        public float InitialEmittionGap
        {
            get
            {
                return this.initialEmittionGapField;
            }
            set
            {
                this.initialEmittionGapField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadInitialPosition InitialPosition
        {
            get
            {
                return this.initialPositionField;
            }
            set
            {
                this.initialPositionField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadRotationXYZ RotationXYZ
        {
            get
            {
                return this.rotationXYZField;
            }
            set
            {
                this.rotationXYZField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadRotationXYZBias RotationXYZBias
        {
            get
            {
                return this.rotationXYZBiasField;
            }
            set
            {
                this.rotationXYZBiasField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadInitialRotationXYZ InitialRotationXYZ
        {
            get
            {
                return this.initialRotationXYZField;
            }
            set
            {
                this.initialRotationXYZField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadInitialRotation InitialRotation
        {
            get
            {
                return this.initialRotationField;
            }
            set
            {
                this.initialRotationField = value;
            }
        }

        /// <remarks/>
        public float InitialEmitterLifeTime
        {
            get
            {
                return this.initialEmitterLifeTimeField;
            }
            set
            {
                this.initialEmitterLifeTimeField = value;
            }
        }

        /// <remarks/>
        public float EmitStartTime
        {
            get
            {
                return this.emitStartTimeField;
            }
            set
            {
                this.emitStartTimeField = value;
            }
        }

        /// <remarks/>
        public string EmitCondition
        {
            get
            {
                return this.emitConditionField;
            }
            set
            {
                this.emitConditionField = value;
            }
        }

        /// <remarks/>
        public string EmitterType
        {
            get
            {
                return this.emitterTypeField;
            }
            set
            {
                this.emitterTypeField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadCylinderParams CylinderParams
        {
            get
            {
                return this.cylinderParamsField;
            }
            set
            {
                this.cylinderParamsField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadSphereParams SphereParams
        {
            get
            {
                return this.sphereParamsField;
            }
            set
            {
                this.sphereParamsField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadBoxParams BoxParams
        {
            get
            {
                return this.boxParamsField;
            }
            set
            {
                this.boxParamsField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadMeshParams MeshParams
        {
            get
            {
                return this.meshParamsField;
            }
            set
            {
                this.meshParamsField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadList ParticleSaveLoadList
        {
            get
            {
                return this.particleSaveLoadListField;
            }
            set
            {
                this.particleSaveLoadListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadExportInfo
    {

        private string exportDateField;

        private string versionField;

        private string authorField;

        /// <remarks/>
        public string ExportDate
        {
            get
            {
                return this.exportDateField;
            }
            set
            {
                this.exportDateField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadInitialPosition
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadRotationXYZ
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadRotationXYZBias
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadInitialRotationXYZ
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadInitialRotation
    {

        private float xField;

        private float yField;

        private float zField;

        private float wField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
        public float W
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadCylinderParams
    {

        private bool m_equiangularlyField;

        private bool m_circumferenceField;

        private bool m_isConeField;

        private float m_angleField;

        private float m_radiusField;

        private float m_heightField;

        private float m_minAngleField;

        private float m_maxAngleField;

        private string m_cylinderEmittionTypeField;

        /// <remarks/>
        public bool m_equiangularly
        {
            get
            {
                return this.m_equiangularlyField;
            }
            set
            {
                this.m_equiangularlyField = value;
            }
        }

        /// <remarks/>
        public bool m_circumference
        {
            get
            {
                return this.m_circumferenceField;
            }
            set
            {
                this.m_circumferenceField = value;
            }
        }

        /// <remarks/>
        public bool m_isCone
        {
            get
            {
                return this.m_isConeField;
            }
            set
            {
                this.m_isConeField = value;
            }
        }

        /// <remarks/>
        public float m_angle
        {
            get
            {
                return this.m_angleField;
            }
            set
            {
                this.m_angleField = value;
            }
        }

        /// <remarks/>
        public float m_radius
        {
            get
            {
                return this.m_radiusField;
            }
            set
            {
                this.m_radiusField = value;
            }
        }

        /// <remarks/>
        public float m_height
        {
            get
            {
                return this.m_heightField;
            }
            set
            {
                this.m_heightField = value;
            }
        }

        /// <remarks/>
        public float m_minAngle
        {
            get
            {
                return this.m_minAngleField;
            }
            set
            {
                this.m_minAngleField = value;
            }
        }

        /// <remarks/>
        public float m_maxAngle
        {
            get
            {
                return this.m_maxAngleField;
            }
            set
            {
                this.m_maxAngleField = value;
            }
        }

        /// <remarks/>
        public string m_cylinderEmittionType
        {
            get
            {
                return this.m_cylinderEmittionTypeField;
            }
            set
            {
                this.m_cylinderEmittionTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadSphereParams
    {

        private float m_latitude_max_angleField;

        private float m_longitude_max_angleField;

        /// <remarks/>
        public float m_latitude_max_angle
        {
            get
            {
                return this.m_latitude_max_angleField;
            }
            set
            {
                this.m_latitude_max_angleField = value;
            }
        }

        /// <remarks/>
        public float m_longitude_max_angle
        {
            get
            {
                return this.m_longitude_max_angleField;
            }
            set
            {
                this.m_longitude_max_angleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadBoxParams
    {

        private InportExportEffectEffectSaveLoadEmitterSaveLoadBoxParamsM_size m_sizeField;

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadBoxParamsM_size m_size
        {
            get
            {
                return this.m_sizeField;
            }
            set
            {
                this.m_sizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadBoxParamsM_size
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadMeshParams
    {

        private object meshNameField;

        /// <remarks/>
        public object MeshName
        {
            get
            {
                return this.meshNameField;
            }
            set
            {
                this.meshNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadList
    {

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoad particleSaveLoadField;

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoad ParticleSaveLoad
        {
            get
            {
                return this.particleSaveLoadField;
            }
            set
            {
                this.particleSaveLoadField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoad
    {

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadExportInfo exportInfoField;

        private string particleNameField;

        private float lifeTimeField;

        private float lifeTimeBiasField;

        private float rotationZField;

        private float rotationZBiasField;

        private float initialRotationZField;

        private ushort initialRotationZBiasField;

        private float initialSpeedField;

        private float initialSpeedBiasField;

        private float zOffsetField;

        private float locusDiffField;

        private float numDivisionField;

        private string locusUVTypeField;

        private bool isBillboardField;

        private bool isEmitterLocalField;

        private string layerTypeField;

        private string pivotTypeField;

        private string uVDescTypeField;

        private string textureIndexTypeField;

        private float textureIndexChangeIntervalField;

        private float textureIndexChangeIntervalBiasField;

        private float initialTextureIndexField;

        private string directionTypeField;

        private uint particleDataFlagsField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadColor colorField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadGravity gravityField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadExternalForce externalForceField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialDirection initialDirectionField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialDirectionBias initialDirectionBiasField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialScale initialScaleField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialScaleBias initialScaleBiasField;

        private string meshNameField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadRotationXYZ rotationXYZField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadRotationXYZBias rotationXYZBiasField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialRotationXYZ initialRotationXYZField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialRotationXYZBias initialRotationXYZBiasField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadUVScrollParam uVScrollParamField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadUVScrollParamAlpha uVScrollParamAlphaField;

        private object refEffectNameField;

        private string refEffectEmitTimingTypeField;

        private float refEffectDelayTimeField;

        private float directionalVelocityRatioField;

        private float deflectionScaleField;

        private float softScaleField;

        private float velocityOffsetField;

        private float userDataField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimation animationField;

        private string materialNameField;

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadExportInfo ExportInfo
        {
            get
            {
                return this.exportInfoField;
            }
            set
            {
                this.exportInfoField = value;
            }
        }

        /// <remarks/>
        public string ParticleName
        {
            get
            {
                return this.particleNameField;
            }
            set
            {
                this.particleNameField = value;
            }
        }

        /// <remarks/>
        public float LifeTime
        {
            get
            {
                return this.lifeTimeField;
            }
            set
            {
                this.lifeTimeField = value;
            }
        }

        /// <remarks/>
        public float LifeTimeBias
        {
            get
            {
                return this.lifeTimeBiasField;
            }
            set
            {
                this.lifeTimeBiasField = value;
            }
        }

        /// <remarks/>
        public float RotationZ
        {
            get
            {
                return this.rotationZField;
            }
            set
            {
                this.rotationZField = value;
            }
        }

        /// <remarks/>
        public float RotationZBias
        {
            get
            {
                return this.rotationZBiasField;
            }
            set
            {
                this.rotationZBiasField = value;
            }
        }

        /// <remarks/>
        public float InitialRotationZ
        {
            get
            {
                return this.initialRotationZField;
            }
            set
            {
                this.initialRotationZField = value;
            }
        }

        /// <remarks/>
        public ushort InitialRotationZBias
        {
            get
            {
                return this.initialRotationZBiasField;
            }
            set
            {
                this.initialRotationZBiasField = value;
            }
        }

        /// <remarks/>
        public float InitialSpeed
        {
            get
            {
                return this.initialSpeedField;
            }
            set
            {
                this.initialSpeedField = value;
            }
        }

        /// <remarks/>
        public float InitialSpeedBias
        {
            get
            {
                return this.initialSpeedBiasField;
            }
            set
            {
                this.initialSpeedBiasField = value;
            }
        }

        /// <remarks/>
        public float ZOffset
        {
            get
            {
                return this.zOffsetField;
            }
            set
            {
                this.zOffsetField = value;
            }
        }

        /// <remarks/>
        public float LocusDiff
        {
            get
            {
                return this.locusDiffField;
            }
            set
            {
                this.locusDiffField = value;
            }
        }

        /// <remarks/>
        public float NumDivision
        {
            get
            {
                return this.numDivisionField;
            }
            set
            {
                this.numDivisionField = value;
            }
        }

        /// <remarks/>
        public string LocusUVType
        {
            get
            {
                return this.locusUVTypeField;
            }
            set
            {
                this.locusUVTypeField = value;
            }
        }

        /// <remarks/>
        public bool IsBillboard
        {
            get
            {
                return this.isBillboardField;
            }
            set
            {
                this.isBillboardField = value;
            }
        }

        /// <remarks/>
        public bool IsEmitterLocal
        {
            get
            {
                return this.isEmitterLocalField;
            }
            set
            {
                this.isEmitterLocalField = value;
            }
        }

        /// <remarks/>
        public string LayerType
        {
            get
            {
                return this.layerTypeField;
            }
            set
            {
                this.layerTypeField = value;
            }
        }

        /// <remarks/>
        public string PivotType
        {
            get
            {
                return this.pivotTypeField;
            }
            set
            {
                this.pivotTypeField = value;
            }
        }

        /// <remarks/>
        public string UVDescType
        {
            get
            {
                return this.uVDescTypeField;
            }
            set
            {
                this.uVDescTypeField = value;
            }
        }

        /// <remarks/>
        public string TextureIndexType
        {
            get
            {
                return this.textureIndexTypeField;
            }
            set
            {
                this.textureIndexTypeField = value;
            }
        }

        /// <remarks/>
        public float TextureIndexChangeInterval
        {
            get
            {
                return this.textureIndexChangeIntervalField;
            }
            set
            {
                this.textureIndexChangeIntervalField = value;
            }
        }

        /// <remarks/>
        public float TextureIndexChangeIntervalBias
        {
            get
            {
                return this.textureIndexChangeIntervalBiasField;
            }
            set
            {
                this.textureIndexChangeIntervalBiasField = value;
            }
        }

        /// <remarks/>
        public float InitialTextureIndex
        {
            get
            {
                return this.initialTextureIndexField;
            }
            set
            {
                this.initialTextureIndexField = value;
            }
        }

        /// <remarks/>
        public string DirectionType
        {
            get
            {
                return this.directionTypeField;
            }
            set
            {
                this.directionTypeField = value;
            }
        }

        /// <remarks/>
        public uint ParticleDataFlags
        {
            get
            {
                return this.particleDataFlagsField;
            }
            set
            {
                this.particleDataFlagsField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadColor Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadGravity Gravity
        {
            get
            {
                return this.gravityField;
            }
            set
            {
                this.gravityField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadExternalForce ExternalForce
        {
            get
            {
                return this.externalForceField;
            }
            set
            {
                this.externalForceField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialDirection InitialDirection
        {
            get
            {
                return this.initialDirectionField;
            }
            set
            {
                this.initialDirectionField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialDirectionBias InitialDirectionBias
        {
            get
            {
                return this.initialDirectionBiasField;
            }
            set
            {
                this.initialDirectionBiasField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialScale InitialScale
        {
            get
            {
                return this.initialScaleField;
            }
            set
            {
                this.initialScaleField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialScaleBias InitialScaleBias
        {
            get
            {
                return this.initialScaleBiasField;
            }
            set
            {
                this.initialScaleBiasField = value;
            }
        }

        /// <remarks/>
        public string MeshName
        {
            get
            {
                return this.meshNameField;
            }
            set
            {
                this.meshNameField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadRotationXYZ RotationXYZ
        {
            get
            {
                return this.rotationXYZField;
            }
            set
            {
                this.rotationXYZField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadRotationXYZBias RotationXYZBias
        {
            get
            {
                return this.rotationXYZBiasField;
            }
            set
            {
                this.rotationXYZBiasField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialRotationXYZ InitialRotationXYZ
        {
            get
            {
                return this.initialRotationXYZField;
            }
            set
            {
                this.initialRotationXYZField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialRotationXYZBias InitialRotationXYZBias
        {
            get
            {
                return this.initialRotationXYZBiasField;
            }
            set
            {
                this.initialRotationXYZBiasField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadUVScrollParam UVScrollParam
        {
            get
            {
                return this.uVScrollParamField;
            }
            set
            {
                this.uVScrollParamField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadUVScrollParamAlpha UVScrollParamAlpha
        {
            get
            {
                return this.uVScrollParamAlphaField;
            }
            set
            {
                this.uVScrollParamAlphaField = value;
            }
        }

        /// <remarks/>
        public object RefEffectName
        {
            get
            {
                return this.refEffectNameField;
            }
            set
            {
                this.refEffectNameField = value;
            }
        }

        /// <remarks/>
        public string RefEffectEmitTimingType
        {
            get
            {
                return this.refEffectEmitTimingTypeField;
            }
            set
            {
                this.refEffectEmitTimingTypeField = value;
            }
        }

        /// <remarks/>
        public float RefEffectDelayTime
        {
            get
            {
                return this.refEffectDelayTimeField;
            }
            set
            {
                this.refEffectDelayTimeField = value;
            }
        }

        /// <remarks/>
        public float DirectionalVelocityRatio
        {
            get
            {
                return this.directionalVelocityRatioField;
            }
            set
            {
                this.directionalVelocityRatioField = value;
            }
        }

        /// <remarks/>
        public float DeflectionScale
        {
            get
            {
                return this.deflectionScaleField;
            }
            set
            {
                this.deflectionScaleField = value;
            }
        }

        /// <remarks/>
        public float SoftScale
        {
            get
            {
                return this.softScaleField;
            }
            set
            {
                this.softScaleField = value;
            }
        }

        /// <remarks/>
        public float VelocityOffset
        {
            get
            {
                return this.velocityOffsetField;
            }
            set
            {
                this.velocityOffsetField = value;
            }
        }

        /// <remarks/>
        public float UserData
        {
            get
            {
                return this.userDataField;
            }
            set
            {
                this.userDataField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimation Animation
        {
            get
            {
                return this.animationField;
            }
            set
            {
                this.animationField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadExportInfo
    {

        private string exportDateField;

        private string versionField;

        private string authorField;

        /// <remarks/>
        public string ExportDate
        {
            get
            {
                return this.exportDateField;
            }
            set
            {
                this.exportDateField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadColor
    {

        private float aField;

        private float rField;

        private float gField;

        private float bField;

        /// <remarks/>
        public float A
        {
            get
            {
                return this.aField;
            }
            set
            {
                this.aField = value;
            }
        }

        /// <remarks/>
        public float R
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        public float G
        {
            get
            {
                return this.gField;
            }
            set
            {
                this.gField = value;
            }
        }

        /// <remarks/>
        public float B
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadGravity
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadExternalForce
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialDirection
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialDirectionBias
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialScale
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialScaleBias
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadRotationXYZ
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadRotationXYZBias
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialRotationXYZ
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadInitialRotationXYZBias
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadUVScrollParam
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadUVScrollParamAlpha
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        public float X
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
        public float Y
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
        public float Z
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimation
    {

        private string versionField;

        private object nameField;

        private string interpTypeField;

        private object trans_xField;

        private object trans_yField;

        private object trans_zField;

        private object scale_xField;

        private object scale_yField;

        private object scale_zField;

        private object rotation_zField;

        private object rotationField;

        private object color_aField;

        private object color_rField;

        private object color_gField;

        private object color_bField;

        private object tex_u0Field;

        private object tex_u1Field;

        private object tex_u2Field;

        private object tex_u3Field;

        private object tex_v0Field;

        private object tex_v1Field;

        private object tex_v2Field;

        private object tex_v3Field;

        private object textureIndexField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationTransX transXField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationTransY transYField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationTransZ transZField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationRotateX rotateXField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationRotateY rotateYField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationRotateZ rotateZField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleX scaleXField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleY scaleYField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleZ scaleZField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorR colorRField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorG colorGField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorB colorBField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorA colorAField;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationU0 u0Field;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationV0 v0Field;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationU1 u1Field;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationV1 v1Field;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationU2 u2Field;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationV2 v2Field;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationU3 u3Field;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationV3 v3Field;

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationTextureIndex textureIndexField1;

        /// <remarks/>
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public object name
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
        public string interpType
        {
            get
            {
                return this.interpTypeField;
            }
            set
            {
                this.interpTypeField = value;
            }
        }

        /// <remarks/>
        public object trans_x
        {
            get
            {
                return this.trans_xField;
            }
            set
            {
                this.trans_xField = value;
            }
        }

        /// <remarks/>
        public object trans_y
        {
            get
            {
                return this.trans_yField;
            }
            set
            {
                this.trans_yField = value;
            }
        }

        /// <remarks/>
        public object trans_z
        {
            get
            {
                return this.trans_zField;
            }
            set
            {
                this.trans_zField = value;
            }
        }

        /// <remarks/>
        public object scale_x
        {
            get
            {
                return this.scale_xField;
            }
            set
            {
                this.scale_xField = value;
            }
        }

        /// <remarks/>
        public object scale_y
        {
            get
            {
                return this.scale_yField;
            }
            set
            {
                this.scale_yField = value;
            }
        }

        /// <remarks/>
        public object scale_z
        {
            get
            {
                return this.scale_zField;
            }
            set
            {
                this.scale_zField = value;
            }
        }

        /// <remarks/>
        public object rotation_z
        {
            get
            {
                return this.rotation_zField;
            }
            set
            {
                this.rotation_zField = value;
            }
        }

        /// <remarks/>
        public object rotation
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

        /// <remarks/>
        public object color_a
        {
            get
            {
                return this.color_aField;
            }
            set
            {
                this.color_aField = value;
            }
        }

        /// <remarks/>
        public object color_r
        {
            get
            {
                return this.color_rField;
            }
            set
            {
                this.color_rField = value;
            }
        }

        /// <remarks/>
        public object color_g
        {
            get
            {
                return this.color_gField;
            }
            set
            {
                this.color_gField = value;
            }
        }

        /// <remarks/>
        public object color_b
        {
            get
            {
                return this.color_bField;
            }
            set
            {
                this.color_bField = value;
            }
        }

        /// <remarks/>
        public object tex_u0
        {
            get
            {
                return this.tex_u0Field;
            }
            set
            {
                this.tex_u0Field = value;
            }
        }

        /// <remarks/>
        public object tex_u1
        {
            get
            {
                return this.tex_u1Field;
            }
            set
            {
                this.tex_u1Field = value;
            }
        }

        /// <remarks/>
        public object tex_u2
        {
            get
            {
                return this.tex_u2Field;
            }
            set
            {
                this.tex_u2Field = value;
            }
        }

        /// <remarks/>
        public object tex_u3
        {
            get
            {
                return this.tex_u3Field;
            }
            set
            {
                this.tex_u3Field = value;
            }
        }

        /// <remarks/>
        public object tex_v0
        {
            get
            {
                return this.tex_v0Field;
            }
            set
            {
                this.tex_v0Field = value;
            }
        }

        /// <remarks/>
        public object tex_v1
        {
            get
            {
                return this.tex_v1Field;
            }
            set
            {
                this.tex_v1Field = value;
            }
        }

        /// <remarks/>
        public object tex_v2
        {
            get
            {
                return this.tex_v2Field;
            }
            set
            {
                this.tex_v2Field = value;
            }
        }

        /// <remarks/>
        public object tex_v3
        {
            get
            {
                return this.tex_v3Field;
            }
            set
            {
                this.tex_v3Field = value;
            }
        }

        /// <remarks/>
        public object textureIndex
        {
            get
            {
                return this.textureIndexField;
            }
            set
            {
                this.textureIndexField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationTransX TransX
        {
            get
            {
                return this.transXField;
            }
            set
            {
                this.transXField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationTransY TransY
        {
            get
            {
                return this.transYField;
            }
            set
            {
                this.transYField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationTransZ TransZ
        {
            get
            {
                return this.transZField;
            }
            set
            {
                this.transZField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationRotateX RotateX
        {
            get
            {
                return this.rotateXField;
            }
            set
            {
                this.rotateXField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationRotateY RotateY
        {
            get
            {
                return this.rotateYField;
            }
            set
            {
                this.rotateYField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationRotateZ RotateZ
        {
            get
            {
                return this.rotateZField;
            }
            set
            {
                this.rotateZField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleX ScaleX
        {
            get
            {
                return this.scaleXField;
            }
            set
            {
                this.scaleXField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleY ScaleY
        {
            get
            {
                return this.scaleYField;
            }
            set
            {
                this.scaleYField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleZ ScaleZ
        {
            get
            {
                return this.scaleZField;
            }
            set
            {
                this.scaleZField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorR ColorR
        {
            get
            {
                return this.colorRField;
            }
            set
            {
                this.colorRField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorG ColorG
        {
            get
            {
                return this.colorGField;
            }
            set
            {
                this.colorGField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorB ColorB
        {
            get
            {
                return this.colorBField;
            }
            set
            {
                this.colorBField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorA ColorA
        {
            get
            {
                return this.colorAField;
            }
            set
            {
                this.colorAField = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationU0 U0
        {
            get
            {
                return this.u0Field;
            }
            set
            {
                this.u0Field = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationV0 V0
        {
            get
            {
                return this.v0Field;
            }
            set
            {
                this.v0Field = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationU1 U1
        {
            get
            {
                return this.u1Field;
            }
            set
            {
                this.u1Field = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationV1 V1
        {
            get
            {
                return this.v1Field;
            }
            set
            {
                this.v1Field = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationU2 U2
        {
            get
            {
                return this.u2Field;
            }
            set
            {
                this.u2Field = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationV2 V2
        {
            get
            {
                return this.v2Field;
            }
            set
            {
                this.v2Field = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationU3 U3
        {
            get
            {
                return this.u3Field;
            }
            set
            {
                this.u3Field = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationV3 V3
        {
            get
            {
                return this.v3Field;
            }
            set
            {
                this.v3Field = value;
            }
        }

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationTextureIndex TextureIndex
        {
            get
            {
                return this.textureIndexField1;
            }
            set
            {
                this.textureIndexField1 = value;
            }
        }
    }

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class KeyFrameList
    {

        private KeyFrameListKeyFrame[] keyFrameField;

        public KeyFrameList()
        {
            KeyFrame = new List<KeyFrameListKeyFrame>().ToArray();
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KeyFrame")]
        public KeyFrameListKeyFrame[] KeyFrame
        {
            get
            {
                return this.keyFrameField;
            }
            set
            {
                this.keyFrameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class KeyFrameListKeyFrame
    {

        private float timeField;

        private float valueField;

        private float valueUpperBiasField;

        private float valueLowerBiasField;

        private float slopeLField;

        private float slopeRField;

        private float slopeLUpperBiasField;

        private float slopeLLowerBiasField;

        private float slopeRUpperBiasField;

        private float slopeRLowerBiasField;

        private bool keyBreakField;

        /// <remarks/>
        public float Time
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
        public float Value
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
        public float ValueUpperBias
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
        public float ValueLowerBias
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
        public float SlopeL
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
        public float SlopeR
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
        public float SlopeLUpperBias
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
        public float SlopeLLowerBias
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
        public float SlopeRUpperBias
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
        public float SlopeRLowerBias
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationTransX
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationTransY
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationTransZ
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationRotateX
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationRotateY
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationRotateZ
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleX
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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

        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleXKeyFrame
    {

        private float timeField;

        private float valueField;

        private float valueUpperBiasField;

        private float valueLowerBiasField;

        private float slopeLField;

        private float slopeRField;

        private float slopeLUpperBiasField;

        private float slopeLLowerBiasField;

        private float slopeRUpperBiasField;

        private float slopeRLowerBiasField;

        private bool keyBreakField;

        /// <remarks/>
        public float Time
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
        public float Value
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
        public float ValueUpperBias
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
        public float ValueLowerBias
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
        public float SlopeL
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
        public float SlopeR
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
        public float SlopeLUpperBias
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
        public float SlopeLLowerBias
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
        public float SlopeRUpperBias
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
        public float SlopeRLowerBias
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleY
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleYKeyFrameList
    {

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleYKeyFrameListKeyFrame keyFrameField;

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleYKeyFrameListKeyFrame KeyFrame
        {
            get
            {
                return this.keyFrameField;
            }
            set
            {
                this.keyFrameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleYKeyFrameListKeyFrame
    {

        private float timeField;

        private float valueField;

        private float valueUpperBiasField;

        private float valueLowerBiasField;

        private float slopeLField;

        private float slopeRField;

        private float slopeLUpperBiasField;

        private float slopeLLowerBiasField;

        private float slopeRUpperBiasField;

        private float slopeRLowerBiasField;

        private bool keyBreakField;

        /// <remarks/>
        public float Time
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
        public float Value
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
        public float ValueUpperBias
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
        public float ValueLowerBias
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
        public float SlopeL
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
        public float SlopeR
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
        public float SlopeLUpperBias
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
        public float SlopeLLowerBias
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
        public float SlopeRUpperBias
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
        public float SlopeRLowerBias
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleZ
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleZKeyFrameList
    {

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleZKeyFrameListKeyFrame keyFrameField;

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleZKeyFrameListKeyFrame KeyFrame
        {
            get
            {
                return this.keyFrameField;
            }
            set
            {
                this.keyFrameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationScaleZKeyFrameListKeyFrame
    {

        private float timeField;

        private float valueField;

        private float valueUpperBiasField;

        private float valueLowerBiasField;

        private float slopeLField;

        private float slopeRField;

        private float slopeLUpperBiasField;

        private float slopeLLowerBiasField;

        private float slopeRUpperBiasField;

        private float slopeRLowerBiasField;

        private bool keyBreakField;

        /// <remarks/>
        public float Time
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
        public float Value
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
        public float ValueUpperBias
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
        public float ValueLowerBias
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
        public float SlopeL
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
        public float SlopeR
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
        public float SlopeLUpperBias
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
        public float SlopeLLowerBias
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
        public float SlopeRUpperBias
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
        public float SlopeRLowerBias
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorR
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorRKeyFrameList
    {

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorRKeyFrameListKeyFrame keyFrameField;

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorRKeyFrameListKeyFrame KeyFrame
        {
            get
            {
                return this.keyFrameField;
            }
            set
            {
                this.keyFrameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorRKeyFrameListKeyFrame
    {

        private float timeField;

        private float valueField;

        private float valueUpperBiasField;

        private float valueLowerBiasField;

        private float slopeLField;

        private float slopeRField;

        private float slopeLUpperBiasField;

        private float slopeLLowerBiasField;

        private float slopeRUpperBiasField;

        private float slopeRLowerBiasField;

        private bool keyBreakField;

        /// <remarks/>
        public float Time
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
        public float Value
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
        public float ValueUpperBias
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
        public float ValueLowerBias
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
        public float SlopeL
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
        public float SlopeR
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
        public float SlopeLUpperBias
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
        public float SlopeLLowerBias
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
        public float SlopeRUpperBias
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
        public float SlopeRLowerBias
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorG
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorGKeyFrameList
    {

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorGKeyFrameListKeyFrame keyFrameField;

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorGKeyFrameListKeyFrame KeyFrame
        {
            get
            {
                return this.keyFrameField;
            }
            set
            {
                this.keyFrameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorGKeyFrameListKeyFrame
    {

        private float timeField;

        private float valueField;

        private float valueUpperBiasField;

        private float valueLowerBiasField;

        private float slopeLField;

        private float slopeRField;

        private float slopeLUpperBiasField;

        private float slopeLLowerBiasField;

        private float slopeRUpperBiasField;

        private float slopeRLowerBiasField;

        private bool keyBreakField;

        /// <remarks/>
        public float Time
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
        public float Value
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
        public float ValueUpperBias
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
        public float ValueLowerBias
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
        public float SlopeL
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
        public float SlopeR
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
        public float SlopeLUpperBias
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
        public float SlopeLLowerBias
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
        public float SlopeRUpperBias
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
        public float SlopeRLowerBias
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorB
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorBKeyFrameList
    {

        private InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorBKeyFrameListKeyFrame keyFrameField;

        /// <remarks/>
        public InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorBKeyFrameListKeyFrame KeyFrame
        {
            get
            {
                return this.keyFrameField;
            }
            set
            {
                this.keyFrameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorBKeyFrameListKeyFrame
    {

        private float timeField;

        private float valueField;

        private float valueUpperBiasField;

        private float valueLowerBiasField;

        private float slopeLField;

        private float slopeRField;

        private float slopeLUpperBiasField;

        private float slopeLLowerBiasField;

        private float slopeRUpperBiasField;

        private float slopeRLowerBiasField;

        private bool keyBreakField;

        /// <remarks/>
        public float Time
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
        public float Value
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
        public float ValueUpperBias
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
        public float ValueLowerBias
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
        public float SlopeL
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
        public float SlopeR
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
        public float SlopeLUpperBias
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
        public float SlopeLLowerBias
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
        public float SlopeRUpperBias
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
        public float SlopeRLowerBias
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorA
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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

        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationColorAKeyFrame
    {

        private float timeField;

        private float valueField;

        private float valueUpperBiasField;

        private float valueLowerBiasField;

        private float slopeLField;

        private float slopeRField;

        private float slopeLUpperBiasField;

        private float slopeLLowerBiasField;

        private float slopeRUpperBiasField;

        private float slopeRLowerBiasField;

        private bool keyBreakField;

        /// <remarks/>
        public float Time
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
        public float Value
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
        public float ValueUpperBias
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
        public float ValueLowerBias
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
        public float SlopeL
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
        public float SlopeR
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
        public float SlopeLUpperBias
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
        public float SlopeLLowerBias
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
        public float SlopeRUpperBias
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
        public float SlopeRLowerBias
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
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationU0
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationV0
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationU1
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationV1
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationU2
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationV2
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationU3
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationV3
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class InportExportEffectEffectSaveLoadEmitterSaveLoadParticleSaveLoadListParticleSaveLoadAnimationTextureIndex
    {

        private object nameField;

        private string curveTypeField;

        private KeyFrameList keyFrameListField;

        /// <remarks/>
        public object Name
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
        public KeyFrameList KeyFrameList
        {
            get
            {
                return this.keyFrameListField;
            }
            set
            {
                this.keyFrameListField = value;
            }
        }
    }


}
