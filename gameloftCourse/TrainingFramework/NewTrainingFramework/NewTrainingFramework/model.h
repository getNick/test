#pragma once
#include "Vertex.h"
#include <vector>
class model
{
public:
	model();
	~model();
	void loadVertices(const char * fileName);
	Vertex *vertices;
	unsigned int *indices;
	GLuint m_hIndexBuffer;
	GLuint m_hVertexBuffer;
	int nrVertices;
	int nrIndices;
};

