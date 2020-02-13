Owen Engle and Carson Custer

How to set up object pooler:
Create player GameObject, attach "inputManager" script, which will automatically attach "Movement" script
Also attach "WeaponManager" script to player
Create an empty GameObject and attach the "BulletPooler" script
	In the inspector, drop in a prefab for a bullet* in "Bulletprefab", set the initial size of the pool under "Pool Size", and toggle 		whether or not the size of the pool can increase during use using the "Can Grow" box

*Bullet prefab must be a gameObject with a rigidBody2D

