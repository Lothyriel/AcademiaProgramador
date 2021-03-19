package Academia_do_Programador;

import java.io.Serializable;
import java.time.LocalDate;

/**
 * @author JX
 */
public class Chamados implements Serializable{
    private int chamado;
    private String desc;
    private Equipamentos equipamento;
    private LocalDate data_abertura;

    public Chamados(int chamado, String desc, Equipamentos equipamento, LocalDate data_abertura) {
        this.chamado = chamado;
        this.desc = desc;
        this.equipamento = equipamento;
        this.data_abertura = data_abertura;
    }

    public int getChamado() {
        return chamado;
    }

    public void setChamado(int chamado) {
        this.chamado = chamado;
    }

    public String getDesc() {
        return desc;
    }

    public void setDesc(String desc) {
        this.desc = desc;
    }

    public Equipamentos getEquipamento() {
        return equipamento;
    }

    public void setEquipamento(Equipamentos equipamento) {
        this.equipamento = equipamento;
    }

    public LocalDate getData_abertura() {
        return data_abertura;
    }

    public void setData_abertura(LocalDate data_abertura) {
        this.data_abertura = data_abertura;
    }
    @Override
    public String toString() {
        return "Chamados{" + "chamado=" + chamado + ", desc=" + desc + ", equipamento=" + equipamento + ", data_abertura=" + data_abertura + '}';
    }
    
}
