//
//  Spring.hpp
//  Spring
//
//  Created by Vishaal Ravikumar on 10/3/16.
//
//

#pragma once
#include "ofMain.h"
#include "Particle.hpp"

class Spring{
    
public:
    
    Spring();
    void set(Particle * _A, Particle * _B);
    void update();
    void draw();
    
    float k;
    float restDist;
    
    
    Particle * A;
    Particle * B;
    
    
    
};