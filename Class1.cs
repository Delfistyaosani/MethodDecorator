using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MethodDecorator.Fody;

using Mono.Cecil;
using MethodDecorator.Fody.Interfaces;
using System.Text.RegularExpressions;
using Mono.Collections.Generic;
using Fody;

public class MW
{

    [CheckRightsDecorator]
    public void ProcessCommand(Command cmd)
    {
        //.method public hidebysig instance void ProcessCommand(class FodyTest.Command cmd) cil managed
        //{
        //    .custom instance void FodyTest.CheckRightsDecoratorAttribute::.ctor()
        //    .maxstack 4
        //    .locals init (
        //        [0] class [mscorlib] System.Reflection.MethodBase base2,
        //        [1] class FodyTest.CheckRightsDecoratorAttribute attribute,
        //        [2] class [mscorlib] System.Exception exception, [3] object[] objArray)
        //    L_0000: nop
        MethodBase method = methodof(LabRat.ProcessCommand, LabRat);
        //    L_0001: ldtoken instance void FodyTest.LabRat::ProcessCommand(class FodyTest.Command)
        //    L_0006: ldtoken FodyTest.LabRat
        //    L_000b: call class [mscorlib] System.Reflection.MethodBase[mscorlib] System.Reflection.MethodBase::GetMethodFromHandle(valuetype[mscorlib] System.RuntimeMethodHandle, valuetype[mscorlib] System.RuntimeTypeHandle)
        //    L_0010: stloc.s base2
        //    L_0012: nop
        CheckRightsDecoratorAttribute attribute = (CheckRightsDecoratorAttribute)Activator.CreateInstance(typeof(CheckRightsDecoratorAttribute));
        //    L_0013: ldtoken FodyTest.CheckRightsDecoratorAttribute
        //    L_0018: call class [mscorlib] System.Type[mscorlib] System.Type::GetTypeFromHandle(valuetype[mscorlib] System.RuntimeTypeHandle)
        //    L_001d: call object[mscorlib] System.Activator::CreateInstance(class [mscorlib] System.Type)
        //    L_0022: castclass FodyTest.CheckRightsDecoratorAttribute
        //    L_0027: stloc.s attribute
        object[] args = new object[] { cmd };
        //    L_0029: ldc.i4 1
        //    L_002e: newarr object
        //    L_0033: stloc objArray
        //    L_0037: ldloc objArray
        //    L_003b: ldc.i4 0
        //    L_0040: ldarg cmd
        //    L_0044: stelem.ref
        attribute.Init(this, method, args);
        //    L_0045: ldloc attribute
        //    L_0049: ldarg.0 
        //    L_004a: ldloc base2
        //    L_004e: ldloc objArray
        //    L_0052: callvirt instance void FodyTest.CheckRightsDecoratorAttribute::Init(object, class [mscorlib] System.Reflection.MethodBase, object[])
        attribute.OnEntry();
        //    L_0057: ldloc attribute
        //    L_005b: callvirt instance void FodyTest.CheckRightsDecoratorAttribute::OnEntry()
        try
        {
            Console.WriteLine("ProcessCommand: Executing " + cmd.Cmd);

            //    L_0060: nop
            //    L_0061: ldstr "ProcessCommand: Executing "
            //    L_0066: ldarg.1 
            //    L_0067: callvirt instance string FodyTest.Command::get_Cmd()
            //    L_006c: call string[mscorlib] System.String::Concat(string, string)
            //    L_0071: call void[mscorlib] System.Console::WriteLine(string)
            //    L_0076: nop
            //    L_0077: br.s L_0079
            attribute.OnExit();
            //    L_0079: ldloc.s attribute
            //    L_007b: callvirt instance void FodyTest.CheckRightsDecoratorAttribute::OnExit()
            //    L_0080: leave.s L_008f
        }
        catch
        {
            attribute.OnException(exception);
            //    L_0082: stloc.s exception
            //    L_0084: ldloc.s attribute
            //    L_0086: ldloc.s exception
            //    L_0088: callvirt instance void FodyTest.CheckRightsDecoratorAttribute::OnException(class [mscorlib] System.Exception)
            throw;
            //    L_008d: rethrow
            //    L_008f: ret
            //    .try L_0060 to L_0082 catch [mscorlib] System.Exception handler L_0082 to L_008f
            //}
        }
    }
}