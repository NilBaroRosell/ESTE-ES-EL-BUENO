#include <iostream>
#include <cstdlib>
#include <string>

struct player  //estad�sticas del player
{
	int health;
	int damage;
};

struct enemy  //estad�sticas de enemigos
{
	int health;
	int damage;
	int x;
	int y;
};

struct weapons  //tipos de armas y su da�o
{
	int damage;
	int weaponType;
};

