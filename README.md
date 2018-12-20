# GE1-Project
Initial Brief
Project for Game Engines 1 module 2018-2019
For this project i would to create that piece tht both reacts to a type of music and can also have controlls that change its state.
I would like to have it so that it can link with the wavelength and tempo of traditional irish music or smooth jazz, although jazz 
not the most exciting and heartpumping genres of music i feel it is something that would be calming to watch while listening to the
relaxing style of music. However when it comes to the traditional irish music there will be a very wide variaton of tempos and rythms.
I would like to keep the background totally black so that the colours and viuals that are being presented stand out more and are more 
vivid, however i will add the ability to flip the intensity of all visuals including the background which will change to white and all 
the visuals will become a darker colour to compensate for the colour switch. There is a video by Peer Play in where he has different 
sound types linked to different objects in the scene that react differently when that sound type is played (https://www.youtube.com/watch?v=eTP_8NXwyNE).
Similarly i plan to have it so that the scene will react differently depending on which instrument is being played at the time, 
which may be quite challenging but i feel it will pay off big time in the end as it should look great. It would have two overall 
modes that each would tailor more to the feel of the two different types of music, so as to not have it purely focused on one visual.
As mentioned previously i hope to have the projects controls ported to a controller that will change the shape of the visualization 
depending on what button you press.

![](Audio%20Visualizer/Vis1.png)

Breakdown
The End product turned out almost as well as i had hoped. After looking at tutorials from youtube and unity poles I managed to come up 
with a visualizer that not only looks well when playing an audio file, but that is also satisfying to watch how it reacts when using the 
mic input and seeing how it reacts to different instruments. When when instruments like the tin whistle are used it reacts very well with 
the scale, and string instruments cause fluctuations in the frequency and pitch. The visualiser is comprised of 8 Rings that rvolve around 
the camera on the x axis 0.5 frames per second which i found to be the best speed for the revolutions. A bool is used to switch between 
mic input and audio file play back. I also added three differnt tracks all with different tempos and style of traditional irish music. A 
flute instrumental, a ballad, and a reel. I chose those specific files to show how diverse the visualiser can be.
The ability to alter the intensity is also available to allow for different combinations based on instument frequency.
The colours of the elements on the rings change shades of green based on whether they are moving or not.
The ability to run the program on mobile is also available with gyroscope camera movement implemented to allow the user to look around and enjoy the experience.

![](Audio%20Visualizer/Gif.gif)

Youtube Video Link - https://youtu.be/wszy9nBCWrA

