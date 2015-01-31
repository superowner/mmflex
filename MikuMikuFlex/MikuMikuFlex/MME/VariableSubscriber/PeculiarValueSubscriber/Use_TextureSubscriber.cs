﻿using SlimDX.Direct3D11;

namespace MMF.MME.VariableSubscriber.PeculiarValueSubscriber
{
    public class Use_TextureSubscriber : PeculiarValueSubscriberBase
    {
        public override string Name
        {
            get { return "use_texture"; }
        }

        public override VariableType Type
        {
            get { return VariableType.Bool; }
        }

        public override void Subscribe(EffectVariable subscribeTo, SubscribeArgument argument)
        {
            subscribeTo.AsScalar().Set(argument.Material.MaterialTexture != null);
        }
    }
}