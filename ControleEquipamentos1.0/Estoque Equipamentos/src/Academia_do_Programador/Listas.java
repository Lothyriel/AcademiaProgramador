package Academia_do_Programador;

import java.io.Serializable;
import java.util.ArrayList;

/**
 * @author JX
 */
class Listas implements Serializable{
    private ArrayList<Equipamentos> equipamentos = new ArrayList();
    private ArrayList<Chamados> chamados = new ArrayList();

    public ArrayList<Equipamentos> getEquipamentos() {
        return equipamentos;
    }
    
    public ArrayList<Chamados> getChamados() {
        return chamados;
    }

    public Listas(ArrayList<Equipamentos> equipamentos,ArrayList<Chamados> chamados) {
        this.equipamentos=equipamentos;
        this.chamados=chamados;
    }

    @Override
    public String toString() {
        return "Listas{" + "equipamentos=" + equipamentos + ", chamados=" + chamados + '}';
    }
    
}
