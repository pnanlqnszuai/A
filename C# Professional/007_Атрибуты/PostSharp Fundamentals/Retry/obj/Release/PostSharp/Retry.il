// Generated by PostSharp 1.0.12.469 at 18/03/2009 14:17:22 (encoding = System.Text.UnicodeEncoding)
.typelist
{
  Retry.RetryAttribute
  Retry.Program
'~PostSharp~Laos~Implementation'
'~PostSharp~Laos~Implementation'/'~delegate~0'
}
.assembly extern PostSharp.Laos
{
  .publickeytoken = (  B1 3F D3 8B 8F 9C 99 D7)
  .ver 1:0:0:0
}
.assembly extern mscorlib
{
  .publickeytoken = (  B7 7A 5C 56 19 34 E0 89)
  .ver 2:0:0:0
}
.assembly extern PostSharp.Public
{
  .publickeytoken = (  B1 3F D3 8B 8F 9C 99 D7)
  .ver 1:0:0:0
}
.assembly Retry
{
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = (  01 00 00 00 00)
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = (  01 00 05 52 65 74 72 79 00 00)
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = (  01 00 08 00 00 00 00 00)
  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = (  01 00 05 52 65 74 72 79 00 00)
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = (  01 00 00 00 00)
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = (  01 00 00 00 00)
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = (  01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01)
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = (  01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20
                                                                                                  20 32 30 30 39 00 00)
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = (  01 00 00 00 00)
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = (  01 00 00 00 00)
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = (  01 00 24 30 35 36 37 38 62 32 35 2D 31 62 36 37
                                                                                                  2D 34 39 32 37 2D 39 62 33 61 2D 66 62 66 34 32
                                                                                                  32 33 36 39 34 35 39 00 00)
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = (  01 00 07 31 2E 30 2E 30 2E 30 00 00)
  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = (  01 00 02 00 00 00 00 00)
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.mresource private '~PostSharp~Laos~CustomAttributes~'
{
}
.module Retry.exe
.imagebase 0xd20000
.file alignment 0x00000200
.stackreserve 0x100000
.subsystem 0x0003
.corflags 0x00000001
.class public auto ansi serializable beforefieldinit Retry.RetryAttribute
      extends [PostSharp.Laos]PostSharp.Laos.OnMethodInvocationAspect
{
}
// End of type: Retry.RetryAttribute


.class private auto ansi beforefieldinit Retry.Program
      extends [mscorlib]System.Object
{
}
// End of type: Retry.Program


.class private auto ansi sealed '~PostSharp~Laos~Implementation'
      extends [mscorlib]System.Object
{
.class auto ansi serializable sealed nested public beforefieldinit '~delegate~0'
      extends [mscorlib]System.MulticastDelegate
{
}
// End of type: ~PostSharp~Laos~Implementation::~delegate~0



}
// End of type: ~PostSharp~Laos~Implementation


.class public auto ansi serializable beforefieldinit Retry.RetryAttribute
      extends [PostSharp.Laos]PostSharp.Laos.OnMethodInvocationAspect
{
  .field private int32  '<Count>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (  01 00 00 00)

  .field private int32  '<DelayMsec>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (  01 00 00 00)

  .method public hidebysig specialname instance int32
          get_Count() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (  01 00 00 00)
    .maxstack 8

  IL_0000:
    ldarg.0   
    ldfld      int32 Retry.RetryAttribute:: '<Count>k__BackingField'
    ret       
  }
  // End of method: Retry.RetryAttribute/get_Count() : int32

  .method public hidebysig specialname instance void
          set_Count(int32  'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (  01 00 00 00)
    .maxstack 8

  IL_0000:
    ldarg.0   
    ldarg.1   
    stfld      int32 Retry.RetryAttribute:: '<Count>k__BackingField'
    ret       
  }
  // End of method: Retry.RetryAttribute/set_Count(int32 value) : void

  .method public hidebysig specialname instance int32
          get_DelayMsec() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (  01 00 00 00)
    .maxstack 8

  IL_0000:
    ldarg.0   
    ldfld      int32 Retry.RetryAttribute:: '<DelayMsec>k__BackingField'
    ret       
  }
  // End of method: Retry.RetryAttribute/get_DelayMsec() : int32

  .method public hidebysig specialname instance void
          set_DelayMsec(int32  'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (  01 00 00 00)
    .maxstack 8

  IL_0000:
    ldarg.0   
    ldarg.1   
    stfld      int32 Retry.RetryAttribute:: '<DelayMsec>k__BackingField'
    ret       
  }
  // End of method: Retry.RetryAttribute/set_DelayMsec(int32 value) : void

  .method public hidebysig specialname rtspecialname
          instance void .ctor(int32 count) cil managed
  {
    .maxstack 8
    .language  '{3f5162f8-07c6-11d3-9053-00c04fa302a1}',  '{994b45c4-e6e9-11d2-903f-00c04fa302a1}',  '{5a869d0b-6611-11d3-bd2a-0000f80849bd}'


  IL_0000:
    .line 13,13 : 5,54  'C:\\Users\\Dmitri\\Projects\\Wild\\PostSharpSamples\\Retry\\Program.cs'
    ldarg.0   
    ldarg.1   
    ldc.i4.0  
    call       instance void Retry.RetryAttribute::.ctor(int32,
                                                         int32)
    .line 13,13 : 57,58
    ret       
  }
  // End of method: Retry.RetryAttribute/.ctor(int32 count) : void

  .method public hidebysig specialname rtspecialname
          instance void .ctor(int32 count,
                              int32 delayMsec) cil managed
  {
    .maxstack 8
    .language  '{3f5162f8-07c6-11d3-9053-00c04fa302a1}',  '{994b45c4-e6e9-11d2-903f-00c04fa302a1}',  '{5a869d0b-6611-11d3-bd2a-0000f80849bd}'


  IL_0000:
    .line 15,15 : 5,52  'C:\\Users\\Dmitri\\Projects\\Wild\\PostSharpSamples\\Retry\\Program.cs'
    ldarg.0   
    call       instance void [PostSharp.Laos]PostSharp.Laos.OnMethodInvocationAspect::.ctor()
    .line 17,17 : 7,21
    ldarg.0   
    ldarg.1   
    call       instance void Retry.RetryAttribute::set_Count(int32)
    .line 18,18 : 7,29
    ldarg.0   
    ldarg.2   
    call       instance void Retry.RetryAttribute::set_DelayMsec(int32)
    .line 19,19 : 5,6
    ret       
  }
  // End of method: Retry.RetryAttribute/.ctor(int32 count, int32 delayMsec) : void

  .method public hidebysig virtual instance void
          OnInvocation(class [PostSharp.Laos]PostSharp.Laos.MethodInvocationEventArgs eventArgs) cil managed
  {
    .maxstack 2
    .language  '{3f5162f8-07c6-11d3-9053-00c04fa302a1}',  '{994b45c4-e6e9-11d2-903f-00c04fa302a1}',  '{5a869d0b-6611-11d3-bd2a-0000f80849bd}'

    {
      .locals init ( [0]  int32 a)

    IL_0000:
      .line 23,23 : 12,22  'C:\\Users\\Dmitri\\Projects\\Wild\\PostSharpSamples\\Retry\\Program.cs'
      ldc.i4.0  
      stloc.0   
      .try
      {

      IL_0001:
        .line 27,27 : 11,39
        ldloc.0   
        brfalse.s  IL_0004

      IL_0002:
        ldarg.0   
        call       instance int32 Retry.RetryAttribute::get_DelayMsec()
        ldc.i4.0  
        ble.s      IL_0004

      IL_0003:
        .line 28,28 : 13,37
        ldarg.0   
        call       instance int32 Retry.RetryAttribute::get_DelayMsec()
        call       void [mscorlib]System.Threading.Thread::Sleep(int32)

      IL_0004:
        .line 29,29 : 11,31
        ldarg.1   
        callvirt   instance void [PostSharp.Laos]PostSharp.Laos.MethodInvocationEventArgs::Proceed()
        .line 30,30 : 11,54
        ldstr       "Succeeded on try "
        ldloc.0   
        box        [mscorlib]System.Int32
        call       string [mscorlib]System.String::Concat(object,
                                                          object)
        call       void [mscorlib]System.Console::WriteLine(string)
        .line 31,31 : 11,18
        leave.s    IL_0009
      }
      catch [mscorlib]System.Object
      {

      IL_0005:
        .line 33,33 : 9,14
        pop       
        .line 35,35 : 11,51
        ldstr       "Failed on try "
        ldloc.0   
        box        [mscorlib]System.Int32
        call       string [mscorlib]System.String::Concat(object,
                                                          object)
        call       void [mscorlib]System.Console::WriteLine(string)
        .line 36,36 : 11,26
        ldloc.0   
        ldarg.0   
        call       instance int32 Retry.RetryAttribute::get_Count()
        bne.un.s   IL_0007

      IL_0006:
        .line 36,36 : 27,33
        rethrow   

      IL_0007:
        .line 0x00feefee
        leave.s    IL_0008
      }

    IL_0008:
      .line 23,23 : 25,28
      ldloc.0   
      ldc.i4.1  
      add       
      stloc.0   
      .line 0x00feefee
      br.s       IL_0001
    }

  IL_0009:
    .line 39,39 : 5,6
    ret       
  }
  // End of method: Retry.RetryAttribute/OnInvocation([PostSharp.Laos]PostSharp.Laos.MethodInvocationEventArgs eventArgs) : void

  .property instance int32 Count()
  {
    .get instance int32 Retry.RetryAttribute::get_Count()
    .set instance void Retry.RetryAttribute::set_Count(int32)
  }

  .property instance int32 DelayMsec()
  {
    .get instance int32 Retry.RetryAttribute::get_DelayMsec()
    .set instance void Retry.RetryAttribute::set_DelayMsec(int32)
  }

}
// End of type: Retry.RetryAttribute


.class private auto ansi beforefieldinit Retry.Program
      extends [mscorlib]System.Object
{
  .field public static class [mscorlib]System.Random rand

  .method public hidebysig static void ICanFail() cil managed
  {
    .custom instance void [mscorlib]System.Diagnostics.DebuggerNonUserCodeAttribute::.ctor()
      = {}
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
      = {}
    .maxstack 3
    {
      .locals init ( [0]  class [mscorlib]System.Delegate delegateInstance,
                     [1]  class [PostSharp.Laos]PostSharp.Laos.MethodInvocationEventArgs eventArgs)

    IL_0000:
      ldnull    
      ldftn      void Retry.Program:: '~ICanFail'()
      newobj     instance void '~PostSharp~Laos~Implementation'/'~delegate~0'::.ctor(object,
                                                                                     native int)
      stloc      0x0000
      ldsfld     class Retry.RetryAttribute '~PostSharp~Laos~Implementation':: 'RetryAttribute~1'
      ldloc      0x0000
      ldnull    
      newobj     instance void [PostSharp.Laos]PostSharp.Laos.MethodInvocationEventArgs::.ctor(class [mscorlib]System.Delegate,
                                                                                               object[] )
      stloc      0x0001
      ldloc      0x0001
      callvirt   instance void [PostSharp.Laos]PostSharp.Laos.IOnMethodInvocationAspect::OnInvocation(class [PostSharp.Laos]PostSharp.Laos.MethodInvocationEventArgs)
      ret       
    }
  }
  // End of method: Retry.Program/ICanFail() : void

  .method private hidebysig static void Main(string[] args) cil managed
  {
    .entrypoint
    .maxstack 2
    .language  '{3f5162f8-07c6-11d3-9053-00c04fa302a1}',  '{994b45c4-e6e9-11d2-903f-00c04fa302a1}',  '{5a869d0b-6611-11d3-bd2a-0000f80849bd}'

    {
      .locals init ( [0]  int32 i)

    IL_0000:
      .line 55,55 : 12,22  'C:\\Users\\Dmitri\\Projects\\Wild\\PostSharpSamples\\Retry\\Program.cs'
      ldc.i4.0  
      stloc.0   
      .line 0x00feefee
      br.s       IL_0004
      .try
      {

      IL_0001:
        .line 58,58 : 11,22
        call       void Retry.Program::ICanFail()
        .line 0x00feefee
        leave.s    IL_0003
      }
      catch [mscorlib]System.Object
      {

      IL_0002:
        .line 60,60 : 9,14
        pop       
        .line 62,62 : 11,58
        ldstr       "=== COMPLETELY FAILED ==="
        call       void [mscorlib]System.Console::WriteLine(string)
        .line 0x00feefee
        leave.s    IL_0003
      }

    IL_0003:
      .line 55,55 : 31,34
      ldloc.0   
      ldc.i4.1  
      add       
      stloc.0   

    IL_0004:
      .line 55,55 : 23,29
      ldloc.0   
      ldc.i4.s   20
      blt.s      IL_0001
    }

  IL_0005:
    .line 64,64 : 5,6
    ret       
  }
  // End of method: Retry.Program/Main(string[] args) : void

  .method public hidebysig specialname rtspecialname
          instance void .ctor() cil managed
  {
    .maxstack 8

  IL_0000:
    ldarg.0   
    call       instance void [mscorlib]System.Object::.ctor()
    ret       
  }
  // End of method: Retry.Program/.ctor() : void

  .method private hidebysig specialname rtspecialname static
          void .cctor() cil managed
  {
    .maxstack 2
    .language  '{3f5162f8-07c6-11d3-9053-00c04fa302a1}',  '{994b45c4-e6e9-11d2-903f-00c04fa302a1}',  '{5a869d0b-6611-11d3-bd2a-0000f80849bd}'

    {
      {

      IL_0001:
        .line 44,44 : 3,4  'C:\\Users\\Dmitri\\Projects\\Wild\\PostSharpSamples\\Retry\\Program.cs'
        nop       
      }
      {
      }
      {

      IL_0004:
        ldsfld     bool '~PostSharp~Laos~Implementation'::initialized
        brtrue.s   IL_0003
        call       void [PostSharp.Laos]PostSharp.Laos.LaosNotInitializedException::Throw()

      IL_0003:
        ldtoken    method void Retry.Program::ICanFail()
        call       class [mscorlib]System.Reflection.MethodBase [mscorlib]System.Reflection.MethodBase::GetMethodFromHandle(valuetype [mscorlib]System.RuntimeMethodHandle)
        stsfld     class [mscorlib]System.Reflection.MethodBase '~PostSharp~Laos~Implementation':: '~targetMethod~1'
        ldsfld     class Retry.RetryAttribute '~PostSharp~Laos~Implementation':: 'RetryAttribute~1'
        ldsfld     class [mscorlib]System.Reflection.MethodBase '~PostSharp~Laos~Implementation':: '~targetMethod~1'
        callvirt   instance void [PostSharp.Laos]PostSharp.Laos.LaosMethodLevelAspect::RuntimeInitialize(class [mscorlib]System.Reflection.MethodBase)
        {

        IL_0000:
          .line 44,44 : 5,46
          newobj     instance void [mscorlib]System.Random::.ctor()
          stsfld     class [mscorlib]System.Random Retry.Program::rand
          .line 0x00feefee
          ret       
        }
      }
    }
  }
  // End of method: Retry.Program/.cctor() : void

  .method private hidebysig static void  '~ICanFail'() cil managed
  {
    .maxstack 8
    .language  '{3f5162f8-07c6-11d3-9053-00c04fa302a1}',  '{994b45c4-e6e9-11d2-903f-00c04fa302a1}',  '{5a869d0b-6611-11d3-bd2a-0000f80849bd}'


  IL_0000:
    .line 49,49 : 7,29  'C:\\Users\\Dmitri\\Projects\\Wild\\PostSharpSamples\\Retry\\Program.cs'
    ldsfld     class [mscorlib]System.Random Retry.Program::rand
    ldc.i4.2  
    callvirt   instance int32 [mscorlib]System.Random::Next(int32)
    brtrue.s   IL_0002

  IL_0001:
    .line 50,50 : 9,47
    ldstr       "I just failed."
    newobj     instance void [mscorlib]System.Exception::.ctor(string)
    throw     

  IL_0002:
    .line 51,51 : 5,6
    ret       
  }
  // End of method: Retry.Program/~ICanFail() : void

}
// End of type: Retry.Program


.class private auto ansi sealed '~PostSharp~Laos~Implementation'
      extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
    = {}
.class auto ansi serializable sealed nested public beforefieldinit '~delegate~0'
      extends [mscorlib]System.MulticastDelegate
{
  .method public hidebysig specialname rtspecialname
          instance void .ctor(object sender,
                              native int  'method') runtime managed
  {
  }
  // End of method: ~PostSharp~Laos~Implementation::~delegate~0/.ctor(object sender, native int method) : void

  .method public hidebysig newslot virtual
          instance void Invoke() runtime managed
  {
  }
  // End of method: ~PostSharp~Laos~Implementation::~delegate~0/Invoke() : void

  .method family hidebysig virtual instance object
          DynamicInvokeImpl(object[] args) cil managed
  {
    .maxstack 1

  IL_0000:
    ldarg.0   
    call       instance void '~PostSharp~Laos~Implementation'/'~delegate~0'::Invoke()
    ldnull    
    ret       
  }
  // End of method: ~PostSharp~Laos~Implementation::~delegate~0/DynamicInvokeImpl(object[] args) : object

}
// End of type: ~PostSharp~Laos~Implementation::~delegate~0



  .field static assembly bool initialized

  .field static assembly initonly class Retry.RetryAttribute  'RetryAttribute~1'

  .field static assembly class [mscorlib]System.Reflection.MethodBase  '~targetMethod~1'

  .method private hidebysig specialname rtspecialname static
          void .cctor() cil managed
  {
    .maxstack 3
    {
      .locals init ( [0]  object[] customAttributeArray)
      .try
      {

      IL_0001:
        ldtoken    '~PostSharp~Laos~Implementation'
        call       class [mscorlib]System.Type [mscorlib]System.Type::GetTypeFromHandle(valuetype [mscorlib]System.RuntimeTypeHandle)
        callvirt   instance class [mscorlib]System.Reflection.Assembly [mscorlib]System.Type::get_Assembly()
        ldstr       "~PostSharp~Laos~CustomAttributes~"
        call       object [PostSharp.Laos]PostSharp.Laos.Internals::DeserializeFromResource(class [mscorlib]System.Reflection.Assembly,
                                                                                            string)
        castclass  object[]
        stloc      0x0000
        ldloc      0x0000
        ldc.i4     0x0
        ldelem     object
        castclass  Retry.RetryAttribute
        stsfld     class Retry.RetryAttribute '~PostSharp~Laos~Implementation':: 'RetryAttribute~1'
        ldc.i4.1  
        stsfld     bool '~PostSharp~Laos~Implementation'::initialized
        leave.s    IL_0000
      }
      catch [mscorlib]System.Exception
      {
        .locals init ( [1]  class [mscorlib]System.Exception e)

      IL_0002:
        stloc      0x0001
        ldc.i4     0x1e
        ldstr       "PostSharp"
        ldloc      0x0001
        callvirt   instance string [mscorlib]System.Exception::get_Message()
        call       void [mscorlib]System.Diagnostics.Debugger::Log(int32,
                                                                   string,
                                                                   string)
        rethrow   
      }

    IL_0000:
      ret       
    }
  }
  // End of method: ~PostSharp~Laos~Implementation/.cctor() : void

}
// End of type: ~PostSharp~Laos~Implementation


