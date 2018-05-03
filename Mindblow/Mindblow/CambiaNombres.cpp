#include <iostream>
#include <cstdlib>
#include <string>

struct player  //estadísticas del player
{
	int health;
	int damage;
};

struct enemy  //estadísticas de enemigos
{
	int health;
	int damage;
	int x;
	int y;
};

struct weapons  //tipos de armas y su daño
{
	int damage;
	int weaponType;
};

