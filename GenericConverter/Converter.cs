using System;
using System.Collections.Generic;
using System.Text;

class Converter<TInput, TOutput>
{
    private TInput _input;
    private TOutput _output;
    private Func<TInput, TOutput> _converFunc;
    public Converter(Func<TInput, TOutput> func)
    {
        _converFunc = func; 
    }

    public TOutput Convert(TInput input)
    {
        _output = _converFunc(input);
        return _output;
    }
    public TOutput[] ConvertAll(TInput[] inputs)
    {
        TOutput[] outputs = new TOutput[inputs.Length];
        for (int i = 0; i < inputs.Length; i++)
        {
            outputs[i] = Convert(inputs[i]);
        }
        return outputs;
    }

}
