using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Annotations;
using Stride.Engine;

namespace Stride.DepInjection
{
    internal class InjectedProcessor : EntityProcessor<ScriptComponent>
    {

        protected override void OnEntityComponentAdding(Entity entity, [NotNull] ScriptComponent component, [NotNull] ScriptComponent data)
        {
            base.OnEntityComponentAdding(entity, component, data);
            //Inject here each field inside the component that have the attribute
        }
    }
}
