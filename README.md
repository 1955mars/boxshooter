![](/BoxShooter/Assets/Images/1.JPG "Box Shooter - A FPS PC game")

# Introduction

Box-Shooter is a First-Person-Shooter single-player 3D game in which the player has to increase the time of survival by shooting particular targets while scoring points at the same time to win the levels.

I have developed a 2-level Box-Shooter game as a part of Coursera's Game design and development specialization. In this article, I'm going to present the design and development process I have taken while building this game.

Watch the gameplay video of Box-Shooter below.

[![Alt text](https://img.youtube.com/vi/lTbncuqbiI0/0.jpg)](https://youtu.be/lTbncuqbiI0)

# The Process

## Persona

|Syntax |Description|
|-------|-----------|
|Name |Neo      |
|Age |10      |
|Occupation |School Student      |
      
    I love playing shooter games.
    
Neo is a student of Class 5. He plays video games on his Dad's desktop at home. He loves playing FPS games.

## Designs, Sketches & Models

### 1. Game Play Environment

This game contains two levels. I came up with the following design for the level 1. 

![](/BoxShooter/Assets/Images/2.JPG "A rough sketch of play arena")

Below is the final level 1 environment that I have built in Unity3D

![](/BoxShooter/Assets/Images/3.JPG "Level 1 environment")

For level 2, I have increased the game-play area and used a  different skybox. The player will be facing more tougher targets which will be explained in the following sections. 

![](/BoxShooter/Assets/Images/3.JPG "Level 2 environment")

### 2. Targets

*Level 1*

![](/BoxShooter/Assets/Images/4.JPG "Positive Target")

Positive Target: Player will get 5 score points if this target is hit.

![](/BoxShooter/Assets/Images/5.JPG "Negative Target")

Negative Target: Player will lose 3 seconds of time if this target is hit.

![](/BoxShooter/Assets/Images/6.JPG "Bonus Target")

Bonus Target: Player will gain 3 seconds of time if this target is hit.

*Level 2*

In Level2, there will be two types of targets as shown below. Both of these are active targets, they shoot back projectiles at the player. Player has to escape from these projectiles all while shooting at them to win the level. 

![](/BoxShooter/Assets/Images/7.JPG "Projectile from targets")

Projectile from Targets: Player will get 5 score points if this projectile is shot in the air. If the projectile hits the player, 5 score points will be lost. 


![](/BoxShooter/Assets/Images/4.JPG "Positive Target")

Positive Target: Player will get 5 score points if this target is hit.


![](/BoxShooter/Assets/Images/6.JPG "Bonus Target")

Bonus + Positive Target: Player will gain 3 seconds of time if this target is hit.

# Breakdown of final piece

The final gameplay of BoxShooter goes like this
1. Level 1 starts with a countdown time of 15 seconds. Before this, the player has to score 25 points to win the level and go to Level2. Player has to hit the positive targets to score points and bonus targets to increase the gameplay time. If the game is lost, the player can choose to play again
2. Level 2 starts with a countdown time of 25 seconds. Before this, the player has to score 30 points to win the game. Player has to escape from the projectiles fired by the targets while shooting back at them to score points and increasing the gameplay time. 
3. If the game is won, the player can choose to restart the game all over again.

# Conclusion

I really enjoyed working on this game. I improved my gameplay programming skills and also revised my 3D vector knowledge while programming the targets to shoot back at the player in Level 2. 

# Next Steps..

If ever I get an opportunity to improvise this game (next version), I would like to replace the box targets with dragons which shoot fireballs back at the player. 
