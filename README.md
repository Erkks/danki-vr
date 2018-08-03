# danki-vr

To be filled in

## Helpful links

1. https://medium.com/inborn-experience/how-to-build-an-app-for-the-oculus-go-from-start-to-finish-with-unity-cb72d931ddae
2. https://developers.google.com/vr/develop/unity/get-started-android

## Development environment positives and negatives

I was starting to tidy up the project so that we have some idea what is important so that the build works and what doesn't and got confused really quickly, especially with what needs to be in a VR project and what doesn't (and how that varies on which platform you build for).

So I started thinking, hmm, is Unity the right thing to proceed with? I started looking at A-frame again (a WebVR framework) as deployment is a lot easier due to web browsers and did a little positives and negatives thing (see below). I think after this, I still think Unity would be the best choice to proceed with, if we want to make this project fully work in terms of immersiveness etc.

1. Ease of development:

1.1 - We'll need to learn 3D concepts anyway, whichever tools we use.

1.2.1 -  Unity positives:

* We have access to a lot of useful 3D libraries;
* Can fine tune bits in the inspector quite easily and see instant feedback;
* Lots of existing documentation and tutorials for (non-VR specific) Unity development;
* Unity might be a useful tool to know for future personal and professional projects as it's solidified itself as an industry standard by now; customisability; 
* Code portability in terms of targeted platforms;
* C# is easy to muddle through for programming beginners (as opposed to JS which can turn very complicated very quickly)
* Sound is supported well and configurable;
* We have VR Unity devs at Pupil already to consult with!

1.2.2 - Unity negatives:

* initial build configuration hell to target different platforms (cardboard VR vs GearVR/Oculus Go vs Vive vs Rift etc.) - need to figure out specific configs for each;
* general steep learning curve for VR development as it's so new;
* lots of complexity up front

1.3.1 - A-frame positives:

* Web/browser-based, so portability and deployment of app to different devices is easy - open in a VR browser;
* html and JS mean that a web-developer can pick up really quickly; 
* Up and coming tech, people will be actively hiring for these skills (working with WebVR and three.js) even if A-frame doesn't succeed

1.3.2 - A-frame negatives:

* Not too many libraries yet;
* JS complexities for JS newbs;
* Not sure if enough control of visual aspect with current libraries;
* Simple sound from what I could tell; 
* New framework so could just die or be overtaken by another one soon;