using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SUC_Converter
{    
    public class ParticleConverter
    {
        static string pathSparkle;
        static string pathGlitter;
        public static void Setup(string pathSU)
        {
            pathSparkle = Utility.AddQuotesIfRequired(pathSU);
        }
        public static void Run()
        {
            InportExportEffect resourceSparkle;
            XmlSerializer serializer = new XmlSerializer(typeof(SUC_Converter.InportExportEffect));
            using (StreamReader reader = new StreamReader(@pathSparkle.Replace("\"","")))
            {
                resourceSparkle = (InportExportEffect)(serializer.Deserialize(reader));
            }

            Effect Effect = new Effect();
            Effect.Name = resourceSparkle.EffectSaveLoad.EffectName;
            Effect.LifeTime = new EffectLifeTime();
            Effect.LifeTime.Value = resourceSparkle.EffectSaveLoad.InitialLifeTime;
            //Effect. = resourceSparkle.EffectSaveLoad.;
            Effect.Rotation = new EffectRotation();
            Effect.Rotation.X = resourceSparkle.EffectSaveLoad.InitialRotation.X;
            Effect.Rotation.Y = resourceSparkle.EffectSaveLoad.InitialRotation.Y;
            Effect.Rotation.Z = resourceSparkle.EffectSaveLoad.InitialRotation.Z;

            Effect.Translation = new EffectTranslation();
            Effect.Translation.X = resourceSparkle.EffectSaveLoad.InitialPosition.X;
            Effect.Translation.Y = resourceSparkle.EffectSaveLoad.InitialPosition.Y;
            Effect.Translation.Z = resourceSparkle.EffectSaveLoad.InitialPosition.Z;

            Effect.Color = new EffectColor();
            Effect.Color.R = 1;
            Effect.Color.G = 1;
            Effect.Color.B = 1;
            Effect.Color.A = 1;
            List<EffectEmitter> emitters = new List<EffectEmitter>();
            List<EffectParticle> particles = new List<EffectParticle>();
            int index = -1;
            foreach(var emitter in resourceSparkle.EffectSaveLoad.EmitterSaveLoadList)
            {
                EffectEmitter gensEmitter = new EffectEmitter();
                gensEmitter.ParticlePerEmission = new EffectEmitterParticlePerEmission();
                gensEmitter.ParticlePerEmission.Value = emitter.MaxGenerateCount;

                gensEmitter.EmissionInterval = new EffectEmitterEmissionInterval();
                gensEmitter.EmissionInterval.Value = (byte)(((float)emitter.InitialEmittionGap) * 60.0f);

                gensEmitter.Translation = new EffectEmitterTranslation();
                gensEmitter.Translation.X = emitter.InitialPosition.X;
                gensEmitter.Translation.Y = emitter.InitialPosition.Y;
                gensEmitter.Translation.Z = emitter.InitialPosition.Z;


                gensEmitter.RotationAdd = new EffectEmitterRotationAdd();
                gensEmitter.RotationAdd.X = emitter.RotationXYZ.X;
                gensEmitter.RotationAdd.Y = emitter.RotationXYZ.Y;
                gensEmitter.RotationAdd.Z = emitter.RotationXYZ.Z;

                gensEmitter.RotationAddRandom = new EffectEmitterRotationAddRandom();
                gensEmitter.RotationAddRandom.X = emitter.RotationXYZBias.X;
                gensEmitter.RotationAddRandom.Y = emitter.RotationXYZBias.Y;
                gensEmitter.RotationAddRandom.Z = emitter.RotationXYZBias.Z;

                gensEmitter.Rotation = new EffectEmitterRotation();
                gensEmitter.Rotation.X = emitter.InitialRotation.X;
                gensEmitter.Rotation.Y = emitter.InitialRotation.Y;
                gensEmitter.Rotation.Z = emitter.InitialRotation.Z;
                gensEmitter.Name = emitter.EmitterName;
                gensEmitter.EmitCondition = new EffectEmitterEmitCondition();
                gensEmitter.EmitCondition.Value = emitter.EmitCondition;
                gensEmitter.Type = emitter.EmitterType;
                switch(emitter.EmitterType)
                {
                    case "Box":
                        {
                            gensEmitter.Size = new EffectEmitterSize();
                            gensEmitter.Size.X = emitter.BoxParams.m_size.X;
                            gensEmitter.Size.Y = emitter.BoxParams.m_size.Y;
                            gensEmitter.Size.Z = emitter.BoxParams.m_size.Z;
                            break;
                        }
                    case "Sphere":
                        {
                            gensEmitter.Latitude = new EffectEmitterLatitude();
                            gensEmitter.Latitude.Value = emitter.SphereParams.m_latitude_max_angle;
                            gensEmitter.Longitude = new EffectEmitterLongitude();
                            gensEmitter.Longitude.Value = emitter.SphereParams.m_longitude_max_angle;
                            break;
                        }
                    case "Cylinder":
                        {
                            gensEmitter.Radius = new EffectEmitterRadius();
                            gensEmitter.Radius.Value = emitter.CylinderParams.m_radius;
                            gensEmitter.Height = new EffectEmitterHeight();
                            gensEmitter.Height.Value = emitter.CylinderParams.m_height;
                            gensEmitter.StartAngle = new EffectEmitterStartAngle();
                            gensEmitter.StartAngle.Value = emitter.CylinderParams.m_minAngle;
                            gensEmitter.EndAngle = new EffectEmitterEndAngle();
                            gensEmitter.EndAngle.Value = emitter.CylinderParams.m_maxAngle;
                            break;
                        }
                }

                EffectParticle gensParticle = new EffectParticle();
                var particleSU = emitter.ParticleSaveLoadList.ParticleSaveLoad;
                gensParticle.Name = particleSU.ParticleName;
                gensParticle.LifeTime = new EffectParticleLifeTime();
                gensParticle.LifeTime.Value = particleSU.LifeTime * 60.0f;
                gensParticle.Speed = new EffectParticleSpeed();
                gensParticle.Speed.Value = particleSU.InitialSpeed / 60.0f;
                gensParticle.SpeedRandom = new EffectParticleSpeedRandom();
                gensParticle.SpeedRandom.Value = particleSU.InitialSpeedBias / 60.0f;
                gensParticle.ZOffset = new EffectParticleZOffset();
                gensParticle.ZOffset.Value = particleSU.ZOffset;
                gensParticle.Type = particleSU.LayerType.Replace("Type", "");
                gensParticle.PivotPosition = new EffectParticlePivotPosition();
                gensParticle.PivotPosition.Value = particleSU.PivotType.Replace("EPivot_", "Middle");
                gensParticle.UvIndexType = new EffectParticleUvIndexType();
                gensParticle.UvIndexType.Value = particleSU.TextureIndexType.Replace("Index", "");
                gensParticle.UvChangeInterval = new EffectParticleUvChangeInterval();
                gensParticle.UvChangeInterval.Value = particleSU.TextureIndexChangeInterval * 60.0f;
                gensParticle.UvIndex = new EffectParticleUvIndex();
                gensParticle.UvIndex.Value = particleSU.InitialTextureIndex;
                gensParticle.DirectionType = new EffectParticleDirectionType();
                gensParticle.DirectionType.Value = particleSU.DirectionType.Replace("EDirection_", "");

                gensParticle.Color = new EffectParticleColor();
                gensParticle.Color.R = particleSU.Color.R;
                gensParticle.Color.G = particleSU.Color.G;
                gensParticle.Color.B = particleSU.Color.B;
                gensParticle.Color.A = particleSU.Color.A;

                gensParticle.GravitationalAccel = new EffectParticleGravitationalAccel();
                gensParticle.GravitationalAccel.X = particleSU.Gravity.X;
                gensParticle.GravitationalAccel.Y = particleSU.Gravity.Y;
                gensParticle.GravitationalAccel.Z = particleSU.Gravity.Z;


                gensParticle.ExternalAccel = new EffectParticleExternalAccel();
                gensParticle.ExternalAccel.X = particleSU.ExternalForce.X;
                gensParticle.ExternalAccel.Y = particleSU.ExternalForce.Y;
                gensParticle.ExternalAccel.Z = particleSU.ExternalForce.Z;


                gensParticle.Direction = new EffectParticleDirection();
                gensParticle.Direction.X = particleSU.InitialDirection.X;  
                gensParticle.Direction.Y = particleSU.InitialDirection.Y;  
                gensParticle.Direction.Z = particleSU.InitialDirection.Z;


                gensParticle.DirectionRandom = new EffectParticleDirectionRandom();
                gensParticle.DirectionRandom.X = particleSU.InitialDirectionBias.X;
                gensParticle.DirectionRandom.Y = particleSU.InitialDirectionBias.Y;
                gensParticle.DirectionRandom.Z = particleSU.InitialDirectionBias.Z;


                gensParticle.Size = new EffectParticleSize();
                gensParticle.Size.X = particleSU.InitialScale.X;
                gensParticle.Size.Y = particleSU.InitialScale.Y;
                gensParticle.Size.Z = particleSU.InitialScale.Z;


                gensParticle.SizeRandom = new EffectParticleSizeRandom();
                gensParticle.SizeRandom.X = particleSU.InitialScaleBias.X;
                gensParticle.SizeRandom.Y = particleSU.InitialScaleBias.Y;
                gensParticle.SizeRandom.Z = particleSU.InitialScaleBias.Z;


                gensParticle.RotationAdd = new EffectParticleRotationAdd();
                gensParticle.RotationAdd.X = particleSU.RotationXYZ.X;
                gensParticle.RotationAdd.Y = particleSU.RotationXYZ.Y;
                gensParticle.RotationAdd.Z = particleSU.RotationXYZ.Z;
                gensParticle.RotationAdd.Z = particleSU.RotationXYZ.Z;

                gensParticle.RotationAddRandom = new EffectParticleRotationAddRandom();
                gensParticle.RotationAddRandom.X = particleSU.RotationXYZBias.X;
                gensParticle.RotationAddRandom.Y = particleSU.RotationXYZBias.Y;
                gensParticle.RotationAddRandom.Z = particleSU.RotationXYZBias.Z;


                gensParticle.Rotation = new EffectParticleRotation();
                gensParticle.Rotation.X = particleSU.InitialRotationXYZ.X;
                gensParticle.Rotation.Y = particleSU.InitialRotationXYZ.Y;
                gensParticle.Rotation.Z = particleSU.InitialRotationXYZ.Z;

                gensParticle.RotationRandom = new EffectParticleRotationRandom();
                gensParticle.RotationRandom.X = particleSU.InitialRotationXYZBias.X;
                gensParticle.RotationRandom.Y = particleSU.InitialRotationXYZBias.Y;
                gensParticle.RotationRandom.Z = particleSU.InitialRotationXYZBias.Z;
                gensEmitter.Particle = new EffectEmitterParticle();
                gensEmitter.Particle.Name = gensParticle.Name;
                index++;
                gensEmitter.Particle.Id = index;
                gensEmitter.Id = index;
                gensParticle.Id = index;
                emitters.Add(gensEmitter);
                particles.Add(gensParticle);
            }
            Effect.Emitter = emitters.ToArray();
            Effect.Particle = particles.ToArray();
            XmlSerializer serializer3 = new XmlSerializer(typeof(Effect));
            using (var fileStream = new StringWriter())
            {
                serializer3.Serialize(fileStream, Effect);
                Clipboard.SetText(fileStream.ToString());
            }
        }
    }
}
