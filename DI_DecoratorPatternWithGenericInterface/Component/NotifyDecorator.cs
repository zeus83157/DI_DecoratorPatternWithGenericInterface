using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Text;

namespace DI_DecoratorPatternWithGenericInterface.Component
{
    public class NotifyDecorator<TRequest, TResponse> : IComponent<TRequest, TResponse>
    {
        private readonly IComponent<TRequest, TResponse> _component;
        public NotifyDecorator(IComponent<TRequest, TResponse> component)
        {
            _component = component;
        }
        public TResponse Execute(TRequest request)
        {
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Speak("Successfully Send requests");
            synthesizer.Speak("and receive a response.");
            return _component.Execute(request);
        }
    }
}
