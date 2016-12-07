// NewTrainingFramework.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "../Utilities/utilities.h" 
#include "Vertex.h"
#include "Shaders.h"
#include "Globals.h"
#include <conio.h>


GLuint vboId;
Shaders myShaders;
Matrix m;
float m_time;
static const unsigned int countIndeces = 36;
GLuint cube;
int Init ( ESContext *esContext )
{
	glClearColor ( 0.0f, 0.0f, 0.0f, 0.0f );
	m.SetIdentity();
	unsigned int indeces[countIndeces] = { 0,1,3,  0,3,2,  2,3,7,  2,7,6,  1,3,5, 3,5,7,  4,7,6,  4,5,7, 0,1,5, 0,5,4, 0,2,6, 0,4,6};
	//triangle data (heap)
	Vertex verticesData[8];
	//position
	verticesData[0].pos.x = -0.5f;  verticesData[0].pos.y = -0.5f;  verticesData[0].pos.z =  0.0f;
	verticesData[1].pos.x = -0.5f;  verticesData[1].pos.y =  0.5f;  verticesData[1].pos.z =  0.0f;
	verticesData[2].pos.x =  0.5f;  verticesData[2].pos.y = -0.5f;  verticesData[2].pos.z =  0.0f;
	verticesData[3].pos.x =  0.5f;  verticesData[3].pos.y =  0.5f;  verticesData[3].pos.z =  0.0f;

	verticesData[4].pos.x = -0.5f;  verticesData[4].pos.y = -0.5f;  verticesData[4].pos.z = -1.0f;
	verticesData[5].pos.x = -0.5f;  verticesData[5].pos.y = 0.5f;  verticesData[5].pos.z = -1.0f;
	verticesData[6].pos.x = 0.5f;  verticesData[6].pos.y = -0.5f;  verticesData[6].pos.z = -1.0f;
	verticesData[7].pos.x = 0.5f;  verticesData[7].pos.y = 0.5f;  verticesData[7].pos.z = -1.0f;
	//color
	verticesData[0].color.x = 1.0f; verticesData[0].color.y = 0.0f; verticesData[0].color.z = 0.0f;
	verticesData[1].color.x = 1.0f; verticesData[1].color.y = 0.0f; verticesData[1].color.z = 0.0f;
	verticesData[2].color.x = 1.0f; verticesData[2].color.y = 0.0f; verticesData[2].color.z = 0.0f;
	verticesData[3].color.x = 1.0f; verticesData[3].color.y = 0.0f; verticesData[3].color.z = 0.0f;
	verticesData[4].color.x = 0.0f; verticesData[4].color.y = 0.0f; verticesData[4].color.z = 1.0f;
	verticesData[5].color.x = 0.0f; verticesData[5].color.y = 0.0f; verticesData[5].color.z = 1.0f;
	verticesData[6].color.x = 0.0f; verticesData[6].color.y = 0.0f; verticesData[6].color.z = 1.0f;
	verticesData[7].color.x = 0.0f; verticesData[7].color.y = 0.0f; verticesData[7].color.z = 1.0f;
	//buffer indeces
	GLuint elementbuffer;
	glGenBuffers(1, &elementbuffer);
	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, elementbuffer);
	glBufferData(GL_ELEMENT_ARRAY_BUFFER, countIndeces*sizeof(unsigned int), indeces, GL_STATIC_DRAW);
	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, elementbuffer);
	//buffer object
	glGenBuffers(1, &vboId); //buffer object name generation
	glBindBuffer(GL_ARRAY_BUFFER, vboId); //buffer object binding
	glBufferData(GL_ARRAY_BUFFER, sizeof(verticesData), verticesData, GL_STATIC_DRAW); //creation and initializion of buffer onject storage
	glBindBuffer(GL_ARRAY_BUFFER, cube);

	//creation of shaders and program 
	return myShaders.Init("../Resources/Shaders/TriangleShaderVS.vs", "../Resources/Shaders/TriangleShaderFS.fs");

}

void Draw ( ESContext *esContext )
{
	glClear(GL_COLOR_BUFFER_BIT);

	glUseProgram(myShaders.program);

	glBindBuffer(GL_ARRAY_BUFFER, vboId);

	GLfloat* ptr = (GLfloat *)0;
	if (myShaders.positionAttribute != -1)
	{
		glEnableVertexAttribArray(myShaders.positionAttribute);
		glVertexAttribPointer(myShaders.positionAttribute, 3, GL_FLOAT, GL_FALSE, sizeof(Vertex), ptr);
		glUniformMatrix4fv(myShaders.matrixTransform, 1, false, (GLfloat *)&m);
	}


	if (myShaders.colorAttribute != -1)
	{
		glEnableVertexAttribArray(myShaders.colorAttribute);
		glVertexAttribPointer(myShaders.colorAttribute, 3, GL_FLOAT, GL_FALSE, sizeof(Vertex), ptr + 3);
	}

	glDrawElements(GL_TRIANGLES, countIndeces, GL_UNSIGNED_INT, (void*)cube);
	//glDrawArrays(GL_TRIANGLE_FAN, 0, 5);

	glBindBuffer(GL_ARRAY_BUFFER, 0);

	eglSwapBuffers ( esContext->eglDisplay, esContext->eglSurface );
}

void Update ( ESContext *esContext, float deltaTime )
{
	m_time += deltaTime;
	m.SetRotationAngleAxis(m_time, 0.1f, 0.0f, 0.1f);
	//m.SetRotationY(m_time);
}

void Key ( ESContext *esContext, unsigned char key, bool bIsPressed)
{

}

void CleanUp()
{
	glDeleteBuffers(1, &vboId);
}

int _tmain(int argc, _TCHAR* argv[])
{
	ESContext esContext;

    esInitContext ( &esContext );

	esCreateWindow ( &esContext, "Hello Triangle", Globals::screenWidth, Globals::screenHeight, ES_WINDOW_RGB | ES_WINDOW_DEPTH);

	if ( Init ( &esContext ) != 0 )
		return 0;

	esRegisterDrawFunc ( &esContext, Draw );
	esRegisterUpdateFunc ( &esContext, Update );
	esRegisterKeyFunc ( &esContext, Key);

	esMainLoop ( &esContext );

	//releasing OpenGL resources
	CleanUp();

	//identifying memory leaks
	MemoryDump();
	printf("Press any key...\n");
	_getch();

	return 0;
}

