namespace Tehanu.Attributes

open System

[<AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)>]
type EffectAttribute() =
  inherit System.Attribute()

type TotalAttribute(expr: string) =
  member this.Expr = expr
