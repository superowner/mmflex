﻿using SlimDX;
using SlimDX.Direct3D11;

namespace MMF.MME.VariableSubscriber.MatrixSubscriber
{
    internal sealed class ProjectionTransposeMatrixSubscriber : MatrixSubscriberBase
    {
        private ProjectionTransposeMatrixSubscriber(ObjectAnnotationType objectAnnotationType)
            : base(objectAnnotationType)
        {
        }

        internal ProjectionTransposeMatrixSubscriber()
        {
        }

        public override string Semantics
        {
            get { return "PROJECTIONTRANSPOSE"; }
        }

        public override void Subscribe(EffectVariable subscribeTo, SubscribeArgument variable)
        {
            if (TargetObject == ObjectAnnotationType.Camera)
                SetAsMatrix(Matrix.Transpose(variable.Context.MatrixManager.ProjectionMatrixManager.ProjectionMatrix),
                    subscribeTo);
        }

        protected override SubscriberBase GetSubscriberInstance(ObjectAnnotationType Object)
        {
            return new ProjectionTransposeMatrixSubscriber(Object);
        }
    }
}