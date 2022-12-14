# Chess engine in Unity 
## Personal Learning Project.
Welcome there! this is a personal learning project that I will be working on as I learn more c# and unity. I was inspired to take on this project and get more into programming by by [Sebastian Lague](https://twitter.com/SebastianLague?ref_src=twsrc%5Egoogle%7Ctwcamp%5Eserp%7Ctwgr%5Eauthor)'s Chess [Coding adventure](https://www.youtube.com/watch?v=U4ogK0MIzqk&ab_channel=SebastianLague), whose coding adventures I wholeheartedly recommend anyone and everyone to checkout.

As this is one of my first personal undertakings there will no doubt be more inspirations that I draw from in terms of both the aesthetics and code implementation, I will do my best to give credit where credit is due and keep a list of said inspirations.

### Inspirations:


- [Sebastian Lague](https://www.youtube.com/watch?v=kkAjpQAM-jE&ab_channel=Tarodev) - Video got me excited to get into things.
- [Tarodev](https://www.youtube.com/@Tarodev) - Had a [video](https://www.youtube.com/watch?v=kkAjpQAM-jE&ab_channel=Tarodev) on how to make a grid and as a bonus it also had a mouse highlight feature (very helpful as I hadn't done much unity).

---

---

## Notes to self (might help others.)

Here I aim to keep some notes for myself in this project to track my own growth and thought process to reflect upon later. This will be a long term project as I have plenty left to learn in c# and especially unity. If these are of benefit to anyone else then that is an added bonus.

---

### Day one (14th December 2022):
Started this project to keep myself motivated while drilling through various programming textbooks, such as [C# Player's Guide](https://csharpplayersguide.com/) (5th edition). Simply wanted to try my hand at drawing out the chess board, started by searching "How to make a grid unity", or at least something along those lines. I immdediately came across a [video](https://www.youtube.com/watch?v=kkAjpQAM-jE&ab_channel=Tarodev) by Tarodev that pretty much did everything I was hoping to challenge myseld with... Well at least I learned some stuff like unity's `OnMouseEnter`, `OnMouseExit` and `SetActive(bool state)`.

The code below for example is to enable or disable whether to rend/show a highlight square child object that is on top of a tile object. The Highlight child object has a low alpha channel to sort of just shift the colour a little.
```cs
private void OnMouseEnter()
    {
        //The hightlight square child of the tile is set to false at instanciation.
        // This sets it to active, that is it is drawn in the game.
        _highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        // Deactivate it again.
        _highlight.SetActive(false);
    }
```

That will be it for this day. In summary:
- we started the project
- initialized the git repository locally
- made this README, first commit 
- added the board drawing code (to be refactored at a later date)
- commited the changes and pushed to github.

Te veo luego. 

---