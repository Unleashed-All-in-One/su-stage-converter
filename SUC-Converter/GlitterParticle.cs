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
    public partial class Effect
    {

        private EffectStartTime startTimeField;

        private EffectLifeTime lifeTimeField;

        private EffectColor colorField;

        private EffectTranslation translationField;

        private EffectRotation rotationField;

        private EffectFlags flagsField;

        private EffectEmitter[] emitterField;

        private EffectParticle[] particleField;

        private string nameField;

        /// <remarks/>
        public EffectStartTime StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        public EffectLifeTime LifeTime
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
        public EffectColor Color
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
        public EffectTranslation Translation
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
        public EffectRotation Rotation
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
        public EffectFlags Flags
        {
            get
            {
                return this.flagsField;
            }
            set
            {
                this.flagsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Emitter")]
        public EffectEmitter[] Emitter
        {
            get
            {
                return this.emitterField;
            }
            set
            {
                this.emitterField = value;
            }
        }

        /// <remarks/>
        public EffectParticle[] Particle
        {
            get
            {
                return this.particleField;
            }
            set
            {
                this.particleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectStartTime
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectLifeTime
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectColor
    {

        private float rField;

        private float gField;

        private float bField;

        private float aField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectTranslation
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectRotation
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectFlags
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitter
    {

        private EffectEmitterStartTime startTimeField;

        private EffectEmitterLifeTime lifeTimeField;

        private EffectEmitterLoopStartTime loopStartTimeField;

        private EffectEmitterLoopEndTime loopEndTimeField;

        private EffectEmitterTranslation translationField;

        private EffectEmitterRotation rotationField;

        private EffectEmitterRotationAdd rotationAddField;

        private EffectEmitterRotationAddRandom rotationAddRandomField;

        private EffectEmitterScaling scalingField;

        private EffectEmitterEmitCondition emitConditionField;

        private EffectEmitterDirectionType directionTypeField;

        private EffectEmitterEmissionInterval emissionIntervalField;

        private EffectEmitterParticlePerEmission particlePerEmissionField;

        private EffectEmitterRadius radiusField;

        private EffectEmitterLatitude latitudeField;

        private EffectEmitterLongitude longitudeField;

        private EffectEmitterHeight heightField;

        private EffectEmitterStartAngle startAngleField;

        private EffectEmitterEndAngle endAngleField;

        private EffectEmitterEmissionDirectionType emissionDirectionTypeField;

        private EffectEmitterSize sizeField;

        private EffectEmitterFlags flagsField;

        private EffectEmitterParticle particleField;

        private float idField;

        private string nameField;

        private string typeField;

        /// <remarks/>
        public EffectEmitterStartTime StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterLifeTime LifeTime
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
        public EffectEmitterLoopStartTime LoopStartTime
        {
            get
            {
                return this.loopStartTimeField;
            }
            set
            {
                this.loopStartTimeField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterLoopEndTime LoopEndTime
        {
            get
            {
                return this.loopEndTimeField;
            }
            set
            {
                this.loopEndTimeField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterTranslation Translation
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
        public EffectEmitterRotation Rotation
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
        public EffectEmitterRotationAdd RotationAdd
        {
            get
            {
                return this.rotationAddField;
            }
            set
            {
                this.rotationAddField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterRotationAddRandom RotationAddRandom
        {
            get
            {
                return this.rotationAddRandomField;
            }
            set
            {
                this.rotationAddRandomField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterScaling Scaling
        {
            get
            {
                return this.scalingField;
            }
            set
            {
                this.scalingField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterEmitCondition EmitCondition
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
        public EffectEmitterDirectionType DirectionType
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
        public EffectEmitterEmissionInterval EmissionInterval
        {
            get
            {
                return this.emissionIntervalField;
            }
            set
            {
                this.emissionIntervalField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterParticlePerEmission ParticlePerEmission
        {
            get
            {
                return this.particlePerEmissionField;
            }
            set
            {
                this.particlePerEmissionField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterRadius Radius
        {
            get
            {
                return this.radiusField;
            }
            set
            {
                this.radiusField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterLatitude Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterLongitude Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterHeight Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterStartAngle StartAngle
        {
            get
            {
                return this.startAngleField;
            }
            set
            {
                this.startAngleField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterEndAngle EndAngle
        {
            get
            {
                return this.endAngleField;
            }
            set
            {
                this.endAngleField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterEmissionDirectionType EmissionDirectionType
        {
            get
            {
                return this.emissionDirectionTypeField;
            }
            set
            {
                this.emissionDirectionTypeField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterSize Size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterFlags Flags
        {
            get
            {
                return this.flagsField;
            }
            set
            {
                this.flagsField = value;
            }
        }

        /// <remarks/>
        public EffectEmitterParticle Particle
        {
            get
            {
                return this.particleField;
            }
            set
            {
                this.particleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float Id
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterStartTime
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterLifeTime
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterLoopStartTime
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterLoopEndTime
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterTranslation
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectEmitterRotation
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectEmitterRotationAdd
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectEmitterRotationAddRandom
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectEmitterScaling
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectEmitterEmitCondition
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterDirectionType
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterEmissionInterval
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterParticlePerEmission
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterRadius
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterLatitude
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterLongitude
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterHeight
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterStartAngle
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterEndAngle
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterEmissionDirectionType
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterSize
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectEmitterFlags
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectEmitterParticle
    {

        private float idField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float Id
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticle
    {

        private EffectParticleLifeTime lifeTimeField;

        private EffectParticlePivotPosition pivotPositionField;

        private EffectParticleDirectionType directionTypeField;

        private EffectParticleZOffset zOffsetField;

        private EffectParticleSize sizeField;

        private EffectParticleSizeRandom sizeRandomField;

        private EffectParticleRotation rotationField;

        private EffectParticleRotationRandom rotationRandomField;

        private EffectParticleRotationAdd rotationAddField;

        private EffectParticleRotationAddRandom rotationAddRandomField;

        private EffectParticleDirection directionField;

        private EffectParticleDirectionRandom directionRandomField;

        private EffectParticleSpeed speedField;

        private EffectParticleSpeedRandom speedRandomField;

        private EffectParticleGravitationalAccel gravitationalAccelField;

        private EffectParticleExternalAccel externalAccelField;

        private EffectParticleExternalAccelRandom externalAccelRandomField;

        private EffectParticleDeceleration decelerationField;

        private EffectParticleDecelerationRandom decelerationRandomField;

        private EffectParticleReflectionCoeff reflectionCoeffField;

        private EffectParticleReflectionCoeffRandom reflectionCoeffRandomField;

        private EffectParticleReboundPlaneY reboundPlaneYField;

        private EffectParticleMaxCount maxCountField;

        private EffectParticleColor colorField;

        private EffectParticleTextureIndex textureIndexField;

        private EffectParticleUvIndexType uvIndexTypeField;

        private EffectParticleUvIndex uvIndexField;

        private EffectParticleUvChangeInterval uvChangeIntervalField;

        private EffectParticleColorScroll colorScrollField;

        private EffectParticleColorScrollRandom colorScrollRandomField;

        private EffectParticleColorScrollSpeed colorScrollSpeedField;

        private EffectParticleAlphaScroll alphaScrollField;

        private EffectParticleAlphaScrollRandom alphaScrollRandomField;

        private EffectParticleAlphaScrollSpeed alphaScrollSpeedField;

        private EffectParticleSecondaryColorScroll secondaryColorScrollField;

        private EffectParticleSecondaryColorScrollRandom secondaryColorScrollRandomField;

        private EffectParticleSecondaryColorScrollSpeed secondaryColorScrollSpeedField;

        private EffectParticleSecondaryAlphaScroll secondaryAlphaScrollField;

        private EffectParticleSecondaryAlphaScrollRandom secondaryAlphaScrollRandomField;

        private EffectParticleSecondaryAlphaScrollSpeed secondaryAlphaScrollSpeedField;

        private EffectParticleMaterial materialField;

        private EffectParticleEmitterTranslationEffectRatio emitterTranslationEffectRatioField;

        private EffectParticleFollowEmitterTranslationRatio followEmitterTranslationRatioField;

        private EffectParticleFollowEmitterTranslationYRatio followEmitterTranslationYRatioField;

        private EffectParticleSecondaryBlendMode secondaryBlendModeField;

        private EffectParticleSecondaryBlend secondaryBlendField;

        private EffectParticleFlags flagsField;

        private EffectParticleAnimation[] animationField;

        private float idField;

        private string nameField;

        private string typeField;

        /// <remarks/>
        public EffectParticleLifeTime LifeTime
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
        public EffectParticlePivotPosition PivotPosition
        {
            get
            {
                return this.pivotPositionField;
            }
            set
            {
                this.pivotPositionField = value;
            }
        }

        /// <remarks/>
        public EffectParticleDirectionType DirectionType
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
        public EffectParticleZOffset ZOffset
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
        public EffectParticleSize Size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        public EffectParticleSizeRandom SizeRandom
        {
            get
            {
                return this.sizeRandomField;
            }
            set
            {
                this.sizeRandomField = value;
            }
        }

        /// <remarks/>
        public EffectParticleRotation Rotation
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
        public EffectParticleRotationRandom RotationRandom
        {
            get
            {
                return this.rotationRandomField;
            }
            set
            {
                this.rotationRandomField = value;
            }
        }

        /// <remarks/>
        public EffectParticleRotationAdd RotationAdd
        {
            get
            {
                return this.rotationAddField;
            }
            set
            {
                this.rotationAddField = value;
            }
        }

        /// <remarks/>
        public EffectParticleRotationAddRandom RotationAddRandom
        {
            get
            {
                return this.rotationAddRandomField;
            }
            set
            {
                this.rotationAddRandomField = value;
            }
        }

        /// <remarks/>
        public EffectParticleDirection Direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
            }
        }

        /// <remarks/>
        public EffectParticleDirectionRandom DirectionRandom
        {
            get
            {
                return this.directionRandomField;
            }
            set
            {
                this.directionRandomField = value;
            }
        }

        /// <remarks/>
        public EffectParticleSpeed Speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }

        /// <remarks/>
        public EffectParticleSpeedRandom SpeedRandom
        {
            get
            {
                return this.speedRandomField;
            }
            set
            {
                this.speedRandomField = value;
            }
        }

        /// <remarks/>
        public EffectParticleGravitationalAccel GravitationalAccel
        {
            get
            {
                return this.gravitationalAccelField;
            }
            set
            {
                this.gravitationalAccelField = value;
            }
        }

        /// <remarks/>
        public EffectParticleExternalAccel ExternalAccel
        {
            get
            {
                return this.externalAccelField;
            }
            set
            {
                this.externalAccelField = value;
            }
        }

        /// <remarks/>
        public EffectParticleExternalAccelRandom ExternalAccelRandom
        {
            get
            {
                return this.externalAccelRandomField;
            }
            set
            {
                this.externalAccelRandomField = value;
            }
        }

        /// <remarks/>
        public EffectParticleDeceleration Deceleration
        {
            get
            {
                return this.decelerationField;
            }
            set
            {
                this.decelerationField = value;
            }
        }

        /// <remarks/>
        public EffectParticleDecelerationRandom DecelerationRandom
        {
            get
            {
                return this.decelerationRandomField;
            }
            set
            {
                this.decelerationRandomField = value;
            }
        }

        /// <remarks/>
        public EffectParticleReflectionCoeff ReflectionCoeff
        {
            get
            {
                return this.reflectionCoeffField;
            }
            set
            {
                this.reflectionCoeffField = value;
            }
        }

        /// <remarks/>
        public EffectParticleReflectionCoeffRandom ReflectionCoeffRandom
        {
            get
            {
                return this.reflectionCoeffRandomField;
            }
            set
            {
                this.reflectionCoeffRandomField = value;
            }
        }

        /// <remarks/>
        public EffectParticleReboundPlaneY ReboundPlaneY
        {
            get
            {
                return this.reboundPlaneYField;
            }
            set
            {
                this.reboundPlaneYField = value;
            }
        }

        /// <remarks/>
        public EffectParticleMaxCount MaxCount
        {
            get
            {
                return this.maxCountField;
            }
            set
            {
                this.maxCountField = value;
            }
        }

        /// <remarks/>
        public EffectParticleColor Color
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
        public EffectParticleTextureIndex TextureIndex
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
        public EffectParticleUvIndexType UvIndexType
        {
            get
            {
                return this.uvIndexTypeField;
            }
            set
            {
                this.uvIndexTypeField = value;
            }
        }

        /// <remarks/>
        public EffectParticleUvIndex UvIndex
        {
            get
            {
                return this.uvIndexField;
            }
            set
            {
                this.uvIndexField = value;
            }
        }

        /// <remarks/>
        public EffectParticleUvChangeInterval UvChangeInterval
        {
            get
            {
                return this.uvChangeIntervalField;
            }
            set
            {
                this.uvChangeIntervalField = value;
            }
        }

        /// <remarks/>
        public EffectParticleColorScroll ColorScroll
        {
            get
            {
                return this.colorScrollField;
            }
            set
            {
                this.colorScrollField = value;
            }
        }

        /// <remarks/>
        public EffectParticleColorScrollRandom ColorScrollRandom
        {
            get
            {
                return this.colorScrollRandomField;
            }
            set
            {
                this.colorScrollRandomField = value;
            }
        }

        /// <remarks/>
        public EffectParticleColorScrollSpeed ColorScrollSpeed
        {
            get
            {
                return this.colorScrollSpeedField;
            }
            set
            {
                this.colorScrollSpeedField = value;
            }
        }

        /// <remarks/>
        public EffectParticleAlphaScroll AlphaScroll
        {
            get
            {
                return this.alphaScrollField;
            }
            set
            {
                this.alphaScrollField = value;
            }
        }

        /// <remarks/>
        public EffectParticleAlphaScrollRandom AlphaScrollRandom
        {
            get
            {
                return this.alphaScrollRandomField;
            }
            set
            {
                this.alphaScrollRandomField = value;
            }
        }

        /// <remarks/>
        public EffectParticleAlphaScrollSpeed AlphaScrollSpeed
        {
            get
            {
                return this.alphaScrollSpeedField;
            }
            set
            {
                this.alphaScrollSpeedField = value;
            }
        }

        /// <remarks/>
        public EffectParticleSecondaryColorScroll SecondaryColorScroll
        {
            get
            {
                return this.secondaryColorScrollField;
            }
            set
            {
                this.secondaryColorScrollField = value;
            }
        }

        /// <remarks/>
        public EffectParticleSecondaryColorScrollRandom SecondaryColorScrollRandom
        {
            get
            {
                return this.secondaryColorScrollRandomField;
            }
            set
            {
                this.secondaryColorScrollRandomField = value;
            }
        }

        /// <remarks/>
        public EffectParticleSecondaryColorScrollSpeed SecondaryColorScrollSpeed
        {
            get
            {
                return this.secondaryColorScrollSpeedField;
            }
            set
            {
                this.secondaryColorScrollSpeedField = value;
            }
        }

        /// <remarks/>
        public EffectParticleSecondaryAlphaScroll SecondaryAlphaScroll
        {
            get
            {
                return this.secondaryAlphaScrollField;
            }
            set
            {
                this.secondaryAlphaScrollField = value;
            }
        }

        /// <remarks/>
        public EffectParticleSecondaryAlphaScrollRandom SecondaryAlphaScrollRandom
        {
            get
            {
                return this.secondaryAlphaScrollRandomField;
            }
            set
            {
                this.secondaryAlphaScrollRandomField = value;
            }
        }

        /// <remarks/>
        public EffectParticleSecondaryAlphaScrollSpeed SecondaryAlphaScrollSpeed
        {
            get
            {
                return this.secondaryAlphaScrollSpeedField;
            }
            set
            {
                this.secondaryAlphaScrollSpeedField = value;
            }
        }

        /// <remarks/>
        public EffectParticleMaterial Material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        /// <remarks/>
        public EffectParticleEmitterTranslationEffectRatio EmitterTranslationEffectRatio
        {
            get
            {
                return this.emitterTranslationEffectRatioField;
            }
            set
            {
                this.emitterTranslationEffectRatioField = value;
            }
        }

        /// <remarks/>
        public EffectParticleFollowEmitterTranslationRatio FollowEmitterTranslationRatio
        {
            get
            {
                return this.followEmitterTranslationRatioField;
            }
            set
            {
                this.followEmitterTranslationRatioField = value;
            }
        }

        /// <remarks/>
        public EffectParticleFollowEmitterTranslationYRatio FollowEmitterTranslationYRatio
        {
            get
            {
                return this.followEmitterTranslationYRatioField;
            }
            set
            {
                this.followEmitterTranslationYRatioField = value;
            }
        }

        /// <remarks/>
        public EffectParticleSecondaryBlendMode SecondaryBlendMode
        {
            get
            {
                return this.secondaryBlendModeField;
            }
            set
            {
                this.secondaryBlendModeField = value;
            }
        }

        /// <remarks/>
        public EffectParticleSecondaryBlend SecondaryBlend
        {
            get
            {
                return this.secondaryBlendField;
            }
            set
            {
                this.secondaryBlendField = value;
            }
        }

        /// <remarks/>
        public EffectParticleFlags Flags
        {
            get
            {
                return this.flagsField;
            }
            set
            {
                this.flagsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Animation")]
        public EffectParticleAnimation[] Animation
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float Id
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleLifeTime
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        public static implicit operator EffectParticleLifeTime(float v)
        {
            throw new NotImplementedException();
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticlePivotPosition
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleDirectionType
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleZOffset
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleSize
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectParticleSizeRandom
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectParticleRotation
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectParticleRotationRandom
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectParticleRotationAdd
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectParticleRotationAddRandom
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectParticleDirection
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectParticleDirectionRandom
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectParticleSpeed
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleSpeedRandom
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleGravitationalAccel
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectParticleExternalAccel
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectParticleExternalAccelRandom
    {

        private float xField;

        private float yField;

        private float zField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class EffectParticleDeceleration
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleDecelerationRandom
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleReflectionCoeff
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleReflectionCoeffRandom
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleReboundPlaneY
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleMaxCount
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleColor
    {

        private float rField;

        private float gField;

        private float bField;

        private float aField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleTextureIndex
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleUvIndexType
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleUvIndex
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleUvChangeInterval
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleColorScroll
    {

        private float uField;

        private float vField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float U
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float V
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleColorScrollRandom
    {

        private float uField;

        private float vField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float U
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float V
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleColorScrollSpeed
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleAlphaScroll
    {

        private float uField;

        private float vField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float U
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float V
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleAlphaScrollRandom
    {

        private float uField;

        private float vField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float U
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float V
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleAlphaScrollSpeed
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleSecondaryColorScroll
    {

        private float uField;

        private float vField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float U
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float V
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleSecondaryColorScrollRandom
    {

        private float uField;

        private float vField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float U
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float V
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleSecondaryColorScrollSpeed
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleSecondaryAlphaScroll
    {

        private float uField;

        private float vField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float U
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float V
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleSecondaryAlphaScrollRandom
    {

        private float uField;

        private float vField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float U
        {
            get
            {
                return this.uField;
            }
            set
            {
                this.uField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public float V
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleSecondaryAlphaScrollSpeed
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleMaterial
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleEmitterTranslationEffectRatio
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleFollowEmitterTranslationRatio
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleFollowEmitterTranslationYRatio
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleSecondaryBlendMode
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleSecondaryBlend
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleFlags
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleAnimation
    {

        private EffectParticleAnimationStartTime startTimeField;

        private EffectParticleAnimationEndTime endTimeField;

        private EffectParticleAnimationRepeatType repeatTypeField;

        private EffectParticleAnimationRandomFlags randomFlagsField;

        private EffectParticleAnimationKey[] keyField;

        private string typeField;

        /// <remarks/>
        public EffectParticleAnimationStartTime StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        public EffectParticleAnimationEndTime EndTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }

        /// <remarks/>
        public EffectParticleAnimationRepeatType RepeatType
        {
            get
            {
                return this.repeatTypeField;
            }
            set
            {
                this.repeatTypeField = value;
            }
        }

        /// <remarks/>
        public EffectParticleAnimationRandomFlags RandomFlags
        {
            get
            {
                return this.randomFlagsField;
            }
            set
            {
                this.randomFlagsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Key")]
        public EffectParticleAnimationKey[] Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleAnimationStartTime
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleAnimationEndTime
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleAnimationRepeatType
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleAnimationRandomFlags
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleAnimationKey
    {

        private EffectParticleAnimationKeyInterpolationType interpolationTypeField;

        private EffectParticleAnimationKeyInParam inParamField;

        private EffectParticleAnimationKeyOutParam outParamField;

        private EffectParticleAnimationKeyRandomRange randomRangeField;

        private float timeField;

        private float valueField;

        /// <remarks/>
        public EffectParticleAnimationKeyInterpolationType InterpolationType
        {
            get
            {
                return this.interpolationTypeField;
            }
            set
            {
                this.interpolationTypeField = value;
            }
        }

        /// <remarks/>
        public EffectParticleAnimationKeyInParam InParam
        {
            get
            {
                return this.inParamField;
            }
            set
            {
                this.inParamField = value;
            }
        }

        /// <remarks/>
        public EffectParticleAnimationKeyOutParam OutParam
        {
            get
            {
                return this.outParamField;
            }
            set
            {
                this.outParamField = value;
            }
        }

        /// <remarks/>
        public EffectParticleAnimationKeyRandomRange RandomRange
        {
            get
            {
                return this.randomRangeField;
            }
            set
            {
                this.randomRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleAnimationKeyInterpolationType
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleAnimationKeyInParam
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleAnimationKeyOutParam
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EffectParticleAnimationKeyRandomRange
    {

        private float valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }



}
