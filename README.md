# Places2SceneRecognitionAPI - Places2 Community API for Dot Net
Places2 (A Large-Scale Database for Scene Understanding Project) Dot Net Api

<h3>What is Places2 Project:</h3>
"The Places2 dataset is designed following principles of human visual cognition. Our goal is to build a core of visual knowledge that can be used to train artificial systems for high-level visual understanding tasks, such as scene context, object recognition, action and event prediction, and theory-of-mind inference. The semantic categories of Places2 are defined by their function: the labels represent the entry-level of an environment. To illustrate, the dataset has different categories of bedrooms, or streets, etc, as one does not act the same way, and does not make the same predictions of what can happen next, in a home bedroom, an hotel bedroom or a nursery.

In total, Places2 contains more than 10 million images comprising 400+ unique scene categories. The dataset features 5000 to 30,000 training images per class, consistent with real-world frequencies of occurrence. Using convolutional neural networks (CNN), Places2 dataset allows learning of deep scene features for various scene recognition tasks, with the goal to establish new state-of-the-art performances on scene-centric benchmarks. Here we provide the Places2 Database and the trained CNNs for academic research and education purposes."<b> MIT</b><br/>

Places2 official website: http://places2.csail.mit.edu/<br/>
Online demo: http://places2.csail.mit.edu/demo.html<br/>
Microsoft image database: http://mscoco.org/<br/>

<h3>How to use Places2SceneRecognitionAPI</h3>

```csharp
  using Places2SceneRecognitionAPI;
  
  
  Places2Parser parser = new Places2Parser();
  List<WebResult> list = parser.ParseData("image_url");
  foreach (WebResult item in list)
  {
    Console.WriteLine("TAG:" + item.Tag + "\nRATIO:" + string.Format("{0:0.0000}\n", item.Ratio));
  }
```

![run sample](http://mesutpiskin.com/blog/wp-content/uploads/2016/07/Screenshot_1.png)
![run sample](http://mesutpiskin.com/blog/wp-content/uploads/2016/07/Screenshot_2.png)
