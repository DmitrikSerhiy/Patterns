namespace Interpreter;

// intent is to give a language and define a representation of translation of that language


public class CirilContext {
    
    public string Input { get; set; }
    
    public string Output { get; set; }
    
    public CirilContext(string input) {
        Input = input;
    }
}

/// <summary>
/// abstract expression
/// </summary>
public abstract class CirilExpression {
    public abstract void Interpret(CirilContext context);
}


public class CirilOneExpression : CirilExpression {
    public override void Interpret(CirilContext context) {

        if (context.Input == "ш") {
            context.Output = "sh";
        }

        if (context.Input == "х") {
            context.Output = "h";
        }
        
        // ...
    }
}