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
    public partial class Scene
    {

        private ScenePause pauseField;

        private SceneSound soundField;

        private SceneStage stageField;

        private SceneOffset offsetField;
        private SceneWait waitField;

        private SceneCamera cameraField;

        private SceneFadeIn fadeInField;

        private SceneFadeOut fadeOutField;

        private SceneShadow shadowField;

        private SceneSet[] depthField;

        private SceneObject[] objectField;

        private string nameField;

        /// <remarks/>
        public ScenePause Pause
        {
            get
            {
                return this.pauseField;
            }
            set
            {
                this.pauseField = value;
            }
        }

        /// <remarks/>
        public SceneSound Sound
        {
            get
            {
                return this.soundField;
            }
            set
            {
                this.soundField = value;
            }
        }

        /// <remarks/>
        public SceneStage Stage
        {
            get
            {
                return this.stageField;
            }
            set
            {
                this.stageField = value;
            }
        }

        /// <remarks/>
        public SceneOffset Offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
        public SceneWait Wait
        {
            get
            {
                return this.waitField;
            }
            set
            {
                this.waitField = value;
            }
        }

        /// <remarks/>
        public SceneCamera Camera
        {
            get
            {
                return this.cameraField;
            }
            set
            {
                this.cameraField = value;
            }
        }

        /// <remarks/>
        public SceneFadeIn FadeIn
        {
            get
            {
                return this.fadeInField;
            }
            set
            {
                this.fadeInField = value;
            }
        }

        /// <remarks/>
        public SceneFadeOut FadeOut
        {
            get
            {
                return this.fadeOutField;
            }
            set
            {
                this.fadeOutField = value;
            }
        }

        /// <remarks/>
        public SceneShadow Shadow
        {
            get
            {
                return this.shadowField;
            }
            set
            {
                this.shadowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Set", IsNullable = false)]
        public SceneSet[] Depth
        {
            get
            {
                return this.depthField;
            }
            set
            {
                this.depthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Object")]
        public SceneObject[] Object
        {
            get
            {
                return this.objectField;
            }
            set
            {
                this.objectField = value;
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
    public partial class ScenePause
    {

        private bool modeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SceneSound
    {

        private string cueSheetField;

        private string cueField;

        private bool localizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CueSheet
        {
            get
            {
                return this.cueSheetField;
            }
            set
            {
                this.cueSheetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Cue
        {
            get
            {
                return this.cueField;
            }
            set
            {
                this.cueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Localize
        {
            get
            {
                return this.localizeField;
            }
            set
            {
                this.localizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SceneStage
    {

        private string nameField;

        private bool hideAutoDrawField;

        private bool hideSetParticleField;

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
        public bool HideAutoDraw
        {
            get
            {
                return this.hideAutoDrawField;
            }
            set
            {
                this.hideAutoDrawField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HideSetParticle
        {
            get
            {
                return this.hideSetParticleField;
            }
            set
            {
                this.hideSetParticleField = value;
            }
        }
    }


    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class SceneWait
    {

        private decimal beforeField;

        private decimal afterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Before
        {
            get
            {
                return this.beforeField;
            }
            set
            {
                this.beforeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal After
        {
            get
            {
                return this.afterField;
            }
            set
            {
                this.afterField = value;
            }
        }
    }




    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SceneOffset
    {

        private decimal txField;

        private decimal tyField;

        private decimal tzField;

        private decimal ryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Tx
        {
            get
            {
                return this.txField;
            }
            set
            {
                this.txField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Ty
        {
            get
            {
                return this.tyField;
            }
            set
            {
                this.tyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Tz
        {
            get
            {
                return this.tzField;
            }
            set
            {
                this.tzField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Ry
        {
            get
            {
                return this.ryField;
            }
            set
            {
                this.ryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SceneCamera
    {

        private string animationField;

        private decimal nearClipField;

        private ushort farClipField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Animation
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
        public decimal NearClip
        {
            get
            {
                return this.nearClipField;
            }
            set
            {
                this.nearClipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort FarClip
        {
            get
            {
                return this.farClipField;
            }
            set
            {
                this.farClipField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SceneFadeIn
    {

        private decimal lengthField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SceneFadeOut
    {

        private decimal lengthField;

        private decimal colorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Color
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SceneShadow
    {

        private SceneShadowSet[] setField;

        private bool enableField;

        private decimal biasField;

        private decimal slopeBiasField;

        private decimal mapSizeField;

        private decimal mapBoxWidthField;

        private decimal mapBoxHeightField;

        private decimal mapBoxNearField;

        private decimal mapBoxFarField;

        private bool verticalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Set")]
        public SceneShadowSet[] Set
        {
            get
            {
                return this.setField;
            }
            set
            {
                this.setField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Enable
        {
            get
            {
                return this.enableField;
            }
            set
            {
                this.enableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Bias
        {
            get
            {
                return this.biasField;
            }
            set
            {
                this.biasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SlopeBias
        {
            get
            {
                return this.slopeBiasField;
            }
            set
            {
                this.slopeBiasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MapSize
        {
            get
            {
                return this.mapSizeField;
            }
            set
            {
                this.mapSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MapBoxWidth
        {
            get
            {
                return this.mapBoxWidthField;
            }
            set
            {
                this.mapBoxWidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MapBoxHeight
        {
            get
            {
                return this.mapBoxHeightField;
            }
            set
            {
                this.mapBoxHeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MapBoxNear
        {
            get
            {
                return this.mapBoxNearField;
            }
            set
            {
                this.mapBoxNearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MapBoxFar
        {
            get
            {
                return this.mapBoxFarField;
            }
            set
            {
                this.mapBoxFarField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Vertical
        {
            get
            {
                return this.verticalField;
            }
            set
            {
                this.verticalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SceneShadowSet
    {

        private decimal cutField;

        private bool enableField;

        private decimal biasField;

        private decimal slopeBiasField;

        private decimal mapSizeField;

        private decimal mapBoxWidthField;

        private decimal mapBoxHeightField;

        private decimal mapBoxNearField;

        private decimal mapBoxFarField;

        private bool verticalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Cut
        {
            get
            {
                return this.cutField;
            }
            set
            {
                this.cutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Enable
        {
            get
            {
                return this.enableField;
            }
            set
            {
                this.enableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Bias
        {
            get
            {
                return this.biasField;
            }
            set
            {
                this.biasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SlopeBias
        {
            get
            {
                return this.slopeBiasField;
            }
            set
            {
                this.slopeBiasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MapSize
        {
            get
            {
                return this.mapSizeField;
            }
            set
            {
                this.mapSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MapBoxWidth
        {
            get
            {
                return this.mapBoxWidthField;
            }
            set
            {
                this.mapBoxWidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MapBoxHeight
        {
            get
            {
                return this.mapBoxHeightField;
            }
            set
            {
                this.mapBoxHeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MapBoxNear
        {
            get
            {
                return this.mapBoxNearField;
            }
            set
            {
                this.mapBoxNearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MapBoxFar
        {
            get
            {
                return this.mapBoxFarField;
            }
            set
            {
                this.mapBoxFarField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Vertical
        {
            get
            {
                return this.verticalField;
            }
            set
            {
                this.verticalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SceneSet
    {

        private decimal cutField;

        private bool enableField;

        private decimal focusField;

        private decimal focusRangeField;

        private decimal rangeNearField;

        private decimal rangeFarField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Cut
        {
            get
            {
                return this.cutField;
            }
            set
            {
                this.cutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Enable
        {
            get
            {
                return this.enableField;
            }
            set
            {
                this.enableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Focus
        {
            get
            {
                return this.focusField;
            }
            set
            {
                this.focusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal FocusRange
        {
            get
            {
                return this.focusRangeField;
            }
            set
            {
                this.focusRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal RangeNear
        {
            get
            {
                return this.rangeNearField;
            }
            set
            {
                this.rangeNearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal RangeFar
        {
            get
            {
                return this.rangeFarField;
            }
            set
            {
                this.rangeFarField = value;
            }
        }
    }
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SceneObjectVisibilityAnimation
    {
        private string nameField;

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
    public partial class SceneObject
    {

        private List<SceneObjectUVAnimation> uVAnimationField;
        private SceneObjectVisibilityAnimation visibilityField;

        private string nameField;

        private string modelField;

        private string skeletonField;

        private string animationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UVAnimation")]
        public List<SceneObjectUVAnimation> UVAnimation
        {
            get
            {
                return this.uVAnimationField;
            }
            set
            {
                this.uVAnimationField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute("VisibilityAnimation")]
        public SceneObjectVisibilityAnimation VisibilityAnimation
        {
            get
            {
                return this.visibilityField;
            }
            set
            {
                this.visibilityField = value;
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
        public string Model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Skeleton
        {
            get
            {
                return this.skeletonField;
            }
            set
            {
                this.skeletonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Animation
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SceneObjectUVAnimation
    {

        private string nameField;

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


}
