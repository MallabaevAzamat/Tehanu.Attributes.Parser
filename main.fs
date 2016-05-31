module Tehanu.Attributes.Parser

open System.IO
open Microsoft.FSharp.Text.Lexing

let parseAttribute text = 
    let lexbuf = LexBuffer<char>.FromString text      
    Parser.start (Lexer.tokenize) lexbuf
