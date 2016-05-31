namespace Tehanu.Attributes

open System

[<AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)>]
type EffectAttribute() = class end

type TotalAttribute(expr: string) =
  member this.Expr = expr
